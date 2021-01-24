using boot.Tools;
using System;
using System.IO;
using System.Net;
using System.Reflection;
using System.Windows.Forms;

namespace boot.WebServer
{
    public class Server
    {
        private HttpListener listener;
        public string Port { get; set; }
        public Server()
        {
            Port = FreePort.FindNextAvailableTCPPort(9000).ToString();
        }
        public void Start()
        {
            listener = new HttpListener();
            listener.Prefixes.Add("http://127.0.0.1:" + Port + "/");
            listener.Start();
            listener.BeginGetContext(listen, listener);
        }
        private void listen(IAsyncResult ar)
        {
            HttpListener svr = (HttpListener)ar.AsyncState;
            HttpListenerContext ctx = svr.EndGetContext(ar);
            listener.BeginGetContext(listen, listener);
            if (ctx.Request.HttpMethod == "GET")
            {
                Get(ctx);
            }
            else if (ctx.Request.HttpMethod == "POST")
            {
                Post(ctx);
            }
            else { }
        }

        public void Get(HttpListenerContext cx)
        {
            string path = Application.StartupPath + "\\web" + cx.Request.RawUrl;
            if (cx.Request.RawUrl == "/")
            {
                path += "index.html";
            }
            cx.Response.StatusCode = 200;
            cx.Response.KeepAlive = true;
            ContentType.SetContentType(cx, Path.GetExtension(path).ToLower());

            if (File.Exists(path))
            {
                try
                {
                    Byte[] buffer = File.ReadAllBytes(path);
                    cx.Response.OutputStream.Write(buffer, 0, buffer.Length);
                    cx.Response.OutputStream.Close();
                    cx.Response.Close();
                }
                catch { }
            }
            else
            {
                cx.Response.OutputStream.Write(System.Text.Encoding.UTF8.GetBytes("404"), 0, 3);
                cx.Response.OutputStream.Close();
                cx.Response.Close();
            }
        }

        public void Post(HttpListenerContext cx)
        {
            cx.Response.StatusCode = 200;
            cx.Response.ContentType = "application/json";
            cx.Response.AppendHeader("Access-Control-Allow-Headers", "Content-Type");
            cx.Response.AppendHeader("Access-Control-Allow-Methods", "Post");
            cx.Response.AppendHeader("Access-Control-Allow-Origin", "*");

            string responseBody = "";
            Byte[] buffer = new Byte[cx.Request.ContentLength64];
            cx.Request.InputStream.Read(buffer, 0, (int)cx.Request.ContentLength64);
            string postData = System.Text.Encoding.UTF8.GetString(buffer);
            postData = System.Web.HttpUtility.UrlDecode(postData);
            responseBody = "";
            Command cmd = Json.GetObject<Command>(postData);
            switch (cmd.Name)
            {
                case "":
                    break;
                default:
                    MethodInfo mi = typeof(Logics).GetMethod(cmd.Name);
                    if (mi != null)
                    {
                        try
                        {
                            responseBody = Json.GetJsonString(mi.Invoke(null, cmd.Arguments.ToArray()));
                        }
                        catch (Exception)
                        {
                        }
                    }
                    else
                    {
                        responseBody = Json.GetJsonString("NOSUCHMETHOD");
                    }
                    break;
            }
            using (StreamWriter sw = new StreamWriter(cx.Response.OutputStream))
            {
                sw.Write(responseBody);
            }

        }
    }
}
