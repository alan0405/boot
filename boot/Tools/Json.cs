using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace boot.Tools
{
    public static class Json
    {
        public static T GetObject<T>(string jsonString)
        {
            JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
            T t1;
            try
            {
                t1 = jsSerializer.Deserialize<T>(jsonString);
            }
            catch (Exception)
            {

                throw;
            }

            return t1;
        }

        public static string GetJsonString(object obj)
        {
            JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
            return jsSerializer.Serialize(obj);
        }
    }
}
