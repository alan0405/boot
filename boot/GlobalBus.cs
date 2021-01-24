
using boot.Service;
using boot.Tools;
using System.Windows.Forms;
namespace boot
{
    public static class GlobalBus
    {
        
        public static Main MainWindow { get; set; }
        public static WebServer.Server WebServer { get; set; }
        public static Console ConsoleWindow { get; set; }

        public static Options _options = null;
        public static Options Options
        {
            get
            {
                if (_options == null)
                {
                    string optionsString = FileService.Read(Application.StartupPath + "\\options.json");
                    _options = Json.GetObject<Options>(optionsString);
                    if (_options == null)
                    {
                        _options = new Options();
                    }                   
                }
                return _options;
            }
        }
    }
}
