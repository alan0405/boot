using System.Net;

namespace boot.WebServer
{
    public static class  ContentType
    {
        public static void SetContentType(HttpListenerContext cx, string ex)
        {
            switch (ex)
            {
                case ".*":
                    cx.Response.ContentType = "application/octet-stream";
                    break;
                case ".tif":
                    cx.Response.ContentType = "image/tiff";
                    break;
                case ".001":
                    cx.Response.ContentType = "application/x-001";
                    break;
                case ".301":
                    cx.Response.ContentType = "application/x-301";
                    break;
                case ".323":
                    cx.Response.ContentType = "text/h323";
                    break;
                case ".906":
                    cx.Response.ContentType = "application/x-906";
                    break;
                case ".907":
                    cx.Response.ContentType = "drawing/907";
                    break;
                case ".a11":
                    cx.Response.ContentType = "application/x-a11";
                    break;
                case ".acp":
                    cx.Response.ContentType = "audio/x-mei-aac";
                    break;
                case ".ai":
                    cx.Response.ContentType = "application/postscript";
                    break;
                case ".aif":
                    cx.Response.ContentType = "audio/aiff";
                    break;
                case ".aifc":
                    cx.Response.ContentType = "audio/aiff";
                    break;
                case ".aiff":
                    cx.Response.ContentType = "audio/aiff";
                    break;
                case ".anv":
                    cx.Response.ContentType = "application/x-anv";
                    break;
                case ".asa":
                    cx.Response.ContentType = "text/asa";
                    break;
                case ".asf":
                    cx.Response.ContentType = "video/x-ms-asf";
                    break;
                case ".asp":
                    cx.Response.ContentType = "text/asp";
                    break;
                case ".asx":
                    cx.Response.ContentType = "video/x-ms-asf";
                    break;
                case ".au":
                    cx.Response.ContentType = "audio/basic";
                    break;
                case ".avi":
                    cx.Response.ContentType = "video/avi";
                    break;
                case ".awf":
                    cx.Response.ContentType = "application/vnd.adobe.workflow";
                    break;
                case ".biz":
                    cx.Response.ContentType = "text/xml";
                    break;
                case ".bmp":
                    cx.Response.ContentType = "application/x-bmp";
                    break;
                case ".bot":
                    cx.Response.ContentType = "application/x-bot";
                    break;
                case ".c4t":
                    cx.Response.ContentType = "application/x-c4t";
                    break;
                case ".c90":
                    cx.Response.ContentType = "application/x-c90";
                    break;
                case ".cal":
                    cx.Response.ContentType = "application/x-cals";
                    break;
                case ".cat":
                    cx.Response.ContentType = "application/vnd.ms-pki.seccat";
                    break;
                case ".cdf":
                    cx.Response.ContentType = "application/x-netcdf";
                    break;
                case ".cdr":
                    cx.Response.ContentType = "application/x-cdr";
                    break;
                case ".cel":
                    cx.Response.ContentType = "application/x-cel";
                    break;
                case ".cer":
                    cx.Response.ContentType = "application/x-x509-ca-cert";
                    break;
                case ".cg4":
                    cx.Response.ContentType = "application/x-g4";
                    break;
                case ".cgm":
                    cx.Response.ContentType = "application/x-cgm";
                    break;
                case ".cit":
                    cx.Response.ContentType = "application/x-cit";
                    break;
                case ".class":
                    cx.Response.ContentType = "java/*";
                    break;
                case ".cml":
                    cx.Response.ContentType = "text/xml";
                    break;
                case ".cmp":
                    cx.Response.ContentType = "application/x-cmp";
                    break;
                case ".cmx":
                    cx.Response.ContentType = "application/x-cmx";
                    break;
                case ".cot":
                    cx.Response.ContentType = "application/x-cot";
                    break;
                case ".crl":
                    cx.Response.ContentType = "application/pkix-crl";
                    break;
                case ".crt":
                    cx.Response.ContentType = "application/x-x509-ca-cert";
                    break;
                case ".csi":
                    cx.Response.ContentType = "application/x-csi";
                    break;
                case ".css":
                    cx.Response.ContentType = "text/css";
                    break;
                case ".cut":
                    cx.Response.ContentType = "application/x-cut";
                    break;
                case ".dbf":
                    cx.Response.ContentType = "application/x-dbf";
                    break;
                case ".dbm":
                    cx.Response.ContentType = "application/x-dbm";
                    break;
                case ".dbx":
                    cx.Response.ContentType = "application/x-dbx";
                    break;
                case ".dcd":
                    cx.Response.ContentType = "text/xml";
                    break;
                case ".dcx":
                    cx.Response.ContentType = "application/x-dcx";
                    break;
                case ".der":
                    cx.Response.ContentType = "application/x-x509-ca-cert";
                    break;
                case ".dgn":
                    cx.Response.ContentType = "application/x-dgn";
                    break;
                case ".dib":
                    cx.Response.ContentType = "application/x-dib";
                    break;
                case ".dll":
                    cx.Response.ContentType = "application/x-msdownload";
                    break;
                case ".doc":
                    cx.Response.ContentType = "application/msword";
                    break;
                case ".dot":
                    cx.Response.ContentType = "application/msword";
                    break;
                case ".drw":
                    cx.Response.ContentType = "application/x-drw";
                    break;
                case ".dtd":
                    cx.Response.ContentType = "text/xml";
                    break;
                case ".dwf":
                    cx.Response.ContentType = "Model/vnd.dwf";
                    break;               
                case ".dwg":
                    cx.Response.ContentType = "application/x-dwg";
                    break;
                case ".dxb":
                    cx.Response.ContentType = "application/x-dxb";
                    break;
                case ".dxf":
                    cx.Response.ContentType = "application/x-dxf";
                    break;
                case ".edn":
                    cx.Response.ContentType = "application/vnd.adobe.edn";
                    break;
                case ".emf":
                    cx.Response.ContentType = "application/x-emf";
                    break;
                case ".eml":
                    cx.Response.ContentType = "message/rfc822";
                    break;
                case ".ent":
                    cx.Response.ContentType = "text/xml";
                    break;
                case ".epi":
                    cx.Response.ContentType = "application/x-epi";
                    break;
                case ".eps":
                    cx.Response.ContentType = "application/x-ps";
                    break;
                case ".etd":
                    cx.Response.ContentType = "application/x-ebx";
                    break;
                case ".exe":
                    cx.Response.ContentType = "application/x-msdownload";
                    break;
                case ".fax":
                    cx.Response.ContentType = "image/fax";
                    break;
                case ".fdf":
                    cx.Response.ContentType = "application/vnd.fdf";
                    break;
                case ".fif":
                    cx.Response.ContentType = "application/fractals";
                    break;
                case ".fo":
                    cx.Response.ContentType = "text/xml";
                    break;
                case ".frm":
                    cx.Response.ContentType = "application/x-frm";
                    break;
                case ".g4":
                    cx.Response.ContentType = "application/x-g4";
                    break;
                case ".gbr":
                    cx.Response.ContentType = "application/x-gbr";
                    break;
                case ".":
                    cx.Response.ContentType = "application/x-";
                    break;
                case ".gif":
                    cx.Response.ContentType = "image/gif";
                    break;
                case ".gl2":
                    cx.Response.ContentType = "application/x-gl2";
                    break;
                case ".gp4":
                    cx.Response.ContentType = "application/x-gp4";
                    break;
                case ".hgl":
                    cx.Response.ContentType = "application/x-hgl";
                    break;
                case ".hmr":
                    cx.Response.ContentType = "application/x-hmr";
                    break;
                case ".hpg":
                    cx.Response.ContentType = "application/x-hpgl";
                    break;
                case ".hpl":
                    cx.Response.ContentType = "application/x-hpl";
                    break;
                case ".hqx":
                    cx.Response.ContentType = "application/mac-binhex40";
                    break;
                case ".hrf":
                    cx.Response.ContentType = "application/x-hrf";
                    break;
                case ".hta":
                    cx.Response.ContentType = "application/hta";
                    break;
                case ".htc":
                    cx.Response.ContentType = "text/x-component";
                    break;
                case ".htm":
                    cx.Response.ContentType = "text/html";
                    break;
                case ".html":
                    cx.Response.ContentType = "text/html";
                    break;
                case ".htt":
                    cx.Response.ContentType = "text/webviewhtml";
                    break;
                case ".htx":
                    cx.Response.ContentType = "text/html";
                    break;
                case ".icb":
                    cx.Response.ContentType = "application/x-icb";
                    break;
                case ".ico":
                    cx.Response.ContentType = "image/x-icon";
                    break;
                case ".iff":
                    cx.Response.ContentType = "application/x-iff";
                    break;
                case ".ig4":
                    cx.Response.ContentType = "application/x-g4";
                    break;
                case ".igs":
                    cx.Response.ContentType = "application/x-igs";
                    break;
                case ".iii":
                    cx.Response.ContentType = "application/x-iphone";
                    break;
                case ".img":
                    cx.Response.ContentType = "application/x-img";
                    break;
                case ".ins":
                    cx.Response.ContentType = "application/x-internet-signup";
                    break;
                case ".isp":
                    cx.Response.ContentType = "application/x-internet-signup";
                    break;
                case ".IVF":
                    cx.Response.ContentType = "video/x-ivf";
                    break;
                case ".java":
                    cx.Response.ContentType = "java/*";
                    break;
                case ".jfif":
                    cx.Response.ContentType = "image/jpeg";
                    break;
                case ".jpe":
                    cx.Response.ContentType = "image/jpeg";
                    break;
                case ".jpeg":
                    cx.Response.ContentType = "image/jpeg";
                    break;
                case ".jpg":
                    cx.Response.ContentType = "image/jpeg";
                    break;
                case ".js":
                    cx.Response.ContentType = "application/x-javascript";
                    break;
                case ".jsp":
                    cx.Response.ContentType = "text/html";
                    break;
                case ".la1":
                    cx.Response.ContentType = "audio/x-liquid-file";
                    break;
                case ".lar":
                    cx.Response.ContentType = "application/x-laplayer-reg";
                    break;
                case ".latex":
                    cx.Response.ContentType = "application/x-latex";
                    break;
                case ".lavs":
                    cx.Response.ContentType = "audio/x-liquid-secure";
                    break;
                case ".lbm":
                    cx.Response.ContentType = "application/x-lbm";
                    break;
                case ".lmsff":
                    cx.Response.ContentType = "audio/x-la-lms";
                    break;
                case ".ls":
                    cx.Response.ContentType = "application/x-javascript";
                    break;
                case ".ltr":
                    cx.Response.ContentType = "application/x-ltr";
                    break;
                case ".m1v":
                    cx.Response.ContentType = "video/x-mpeg";
                    break;
                case ".m2v":
                    cx.Response.ContentType = "video/x-mpeg";
                    break;
                case ".m3u":
                    cx.Response.ContentType = "audio/mpegurl";
                    break;
                case ".m4e":
                    cx.Response.ContentType = "video/mpeg4";
                    break;
                case ".mac":
                    cx.Response.ContentType = "application/x-mac";
                    break;
                case ".man":
                    cx.Response.ContentType = "application/x-troff-man";
                    break;
                case ".math":
                    cx.Response.ContentType = "text/xml";
                    break;
                case ".mdb":
                    cx.Response.ContentType = "application/msaccess";
                    break;
                case ".mfp":
                    cx.Response.ContentType = "application/x-shockwave-flash";
                    break;
                case ".mht":
                    cx.Response.ContentType = "message/rfc822";
                    break;
                case ".mhtml":
                    cx.Response.ContentType = "message/rfc822";
                    break;
                case ".mi":
                    cx.Response.ContentType = "application/x-mi";
                    break;
                case ".mid":
                    cx.Response.ContentType = "audio/mid";
                    break;
                case ".midi":
                    cx.Response.ContentType = "audio/mid";
                    break;
                case ".mil":
                    cx.Response.ContentType = "application/x-mil";
                    break;
                case ".mml":
                    cx.Response.ContentType = "text/xml";
                    break;
                case ".mnd":
                    cx.Response.ContentType = "audio/x-musicnet-download";
                    break;
                case ".mns":
                    cx.Response.ContentType = "audio/x-musicnet-stream";
                    break;
                case ".mocha":
                    cx.Response.ContentType = "application/x-javascript";
                    break;
                case ".movie":
                    cx.Response.ContentType = "video/x-sgi-movie";
                    break;
                case ".mp1":
                    cx.Response.ContentType = "audio/mp1";
                    break;
                case ".mp2":
                    cx.Response.ContentType = "audio/mp2";
                    break;
                case ".mp2v":
                    cx.Response.ContentType = "video/mpeg";
                    break;
                case ".mp3":
                    cx.Response.ContentType = "audio/mp3";
                    break;
                case ".mp4":
                    cx.Response.ContentType = "video/mpeg4";
                    break;
                case ".mpa":
                    cx.Response.ContentType = "video/x-mpg";
                    break;
                case ".mpd":
                    cx.Response.ContentType = "application/vnd.ms-project";
                    break;
                case ".mpe":
                    cx.Response.ContentType = "video/x-mpeg";
                    break;
                case ".mpeg":
                    cx.Response.ContentType = "video/mpg";
                    break;
                case ".mpg":
                    cx.Response.ContentType = "video/mpg";
                    break;
                case ".mpga":
                    cx.Response.ContentType = "audio/rn-mpeg";
                    break;
                case ".mpp":
                    cx.Response.ContentType = "application/vnd.ms-project";
                    break;
                case ".mps":
                    cx.Response.ContentType = "video/x-mpeg";
                    break;
                case ".mpt":
                    cx.Response.ContentType = "application/vnd.ms-project";
                    break;
                case ".mpv":
                    cx.Response.ContentType = "video/mpg";
                    break;
                case ".mpv2":
                    cx.Response.ContentType = "video/mpeg";
                    break;
                case ".mpw":
                    cx.Response.ContentType = "application/vnd.ms-project";
                    break;
                case ".mpx":
                    cx.Response.ContentType = "application/vnd.ms-project";
                    break;
                case ".mtx":
                    cx.Response.ContentType = "text/xml";
                    break;
                case ".mxp":
                    cx.Response.ContentType = "application/x-mmxp";
                    break;
                case ".net":
                    cx.Response.ContentType = "image/pnetvue";
                    break;
                case ".nrf":
                    cx.Response.ContentType = "application/x-nrf";
                    break;
                case ".nws":
                    cx.Response.ContentType = "message/rfc822";
                    break;
                case ".odc":
                    cx.Response.ContentType = "text/x-ms-odc";
                    break;
                case ".out":
                    cx.Response.ContentType = "application/x-out";
                    break;
                case ".p10":
                    cx.Response.ContentType = "application/pkcs10";
                    break;
                case ".p12":
                    cx.Response.ContentType = "application/x-pkcs12";
                    break;
                case ".p7b":
                    cx.Response.ContentType = "application/x-pkcs7-certificates";
                    break;
                case ".p7c":
                    cx.Response.ContentType = "application/pkcs7-mime";
                    break;
                case ".p7m":
                    cx.Response.ContentType = "application/pkcs7-mime";
                    break;
                case ".p7r":
                    cx.Response.ContentType = "application/x-pkcs7-certreqresp";
                    break;
                case ".p7s":
                    cx.Response.ContentType = "application/pkcs7-signature";
                    break;
                case ".pc5":
                    cx.Response.ContentType = "application/x-pc5";
                    break;
                case ".pci":
                    cx.Response.ContentType = "application/x-pci";
                    break;
                case ".pcl":
                    cx.Response.ContentType = "application/x-pcl";
                    break;
                case ".pcx":
                    cx.Response.ContentType = "application/x-pcx";
                    break;
                case ".pdf":
                    cx.Response.ContentType = "application/pdf";
                    break;
                case ".pdx":
                    cx.Response.ContentType = "application/vnd.adobe.pdx";
                    break;
                case ".pfx":
                    cx.Response.ContentType = "application/x-pkcs12";
                    break;
                case ".pgl":
                    cx.Response.ContentType = "application/x-pgl";
                    break;
                case ".pic":
                    cx.Response.ContentType = "application/x-pic";
                    break;
                case ".pko":
                    cx.Response.ContentType = "application/vnd.ms-pki.pko";
                    break;
                case ".pl":
                    cx.Response.ContentType = "application/x-perl";
                    break;
                case ".plg":
                    cx.Response.ContentType = "text/html";
                    break;
                case ".pls":
                    cx.Response.ContentType = "audio/scpls";
                    break;
                case ".plt":
                    cx.Response.ContentType = "application/x-plt";
                    break;
                case ".png":
                    cx.Response.ContentType = "image/png";
                    break;
                case ".pot":
                    cx.Response.ContentType = "application/vnd.ms-powerpoint";
                    break;
                case ".ppa":
                    cx.Response.ContentType = "application/vnd.ms-powerpoint";
                    break;
                case ".ppm":
                    cx.Response.ContentType = "application/x-ppm";
                    break;
                case ".pps":
                    cx.Response.ContentType = "application/vnd.ms-powerpoint";
                    break;
                case ".ppt":
                    cx.Response.ContentType = "application/vnd.ms-powerpoint";
                    break;
                case ".pr":
                    cx.Response.ContentType = "application/x-pr";
                    break;
                case ".prf":
                    cx.Response.ContentType = "application/pics-rules";
                    break;
                case ".prn":
                    cx.Response.ContentType = "application/x-prn";
                    break;
                case ".prt":
                    cx.Response.ContentType = "application/x-prt";
                    break;
                case ".ps":
                    cx.Response.ContentType = "application/x-ps";
                    break;
                case ".ptn":
                    cx.Response.ContentType = "application/x-ptn";
                    break;
                case ".pwz":
                    cx.Response.ContentType = "application/vnd.ms-powerpoint";
                    break;
                case ".r3t":
                    cx.Response.ContentType = "text/vnd.rn-realtext3d";
                    break;
                case ".ra":
                    cx.Response.ContentType = "audio/vnd.rn-realaudio";
                    break;
                case ".ram":
                    cx.Response.ContentType = "audio/x-pn-realaudio";
                    break;
                case ".ras":
                    cx.Response.ContentType = "application/x-ras";
                    break;
                case ".rat":
                    cx.Response.ContentType = "application/rat-file";
                    break;
                case ".rdf":
                    cx.Response.ContentType = "text/xml";
                    break;
                case ".rec":
                    cx.Response.ContentType = "application/vnd.rn-recording";
                    break;
                case ".red":
                    cx.Response.ContentType = "application/x-red";
                    break;
                case ".rgb":
                    cx.Response.ContentType = "application/x-rgb";
                    break;
                case ".rjs":
                    cx.Response.ContentType = "application/vnd.rn-realsystem-rjs";
                    break;
                case ".rjt":
                    cx.Response.ContentType = "application/vnd.rn-realsystem-rjt";
                    break;
                case ".rlc":
                    cx.Response.ContentType = "application/x-rlc";
                    break;
                case ".rle":
                    cx.Response.ContentType = "application/x-rle";
                    break;
                case ".rm":
                    cx.Response.ContentType = "application/vnd.rn-realmedia";
                    break;
                case ".rmf":
                    cx.Response.ContentType = "application/vnd.adobe.rmf";
                    break;
                case ".rmi":
                    cx.Response.ContentType = "audio/mid";
                    break;
                case ".rmj":
                    cx.Response.ContentType = "application/vnd.rn-realsystem-rmj";
                    break;
                case ".rmm":
                    cx.Response.ContentType = "audio/x-pn-realaudio";
                    break;
                case ".rmp":
                    cx.Response.ContentType = "application/vnd.rn-rn_music_package";
                    break;
                case ".rms":
                    cx.Response.ContentType = "application/vnd.rn-realmedia-secure";
                    break;
                case ".rmvb":
                    cx.Response.ContentType = "application/vnd.rn-realmedia-vbr";
                    break;
                case ".rmx":
                    cx.Response.ContentType = "application/vnd.rn-realsystem-rmx";
                    break;
                case ".rnx":
                    cx.Response.ContentType = "application/vnd.rn-realplayer";
                    break;
                case ".rp":
                    cx.Response.ContentType = "image/vnd.rn-realpix";
                    break;
                case ".rpm":
                    cx.Response.ContentType = "audio/x-pn-realaudio-plugin";
                    break;
                case ".rsml":
                    cx.Response.ContentType = "application/vnd.rn-rsml";
                    break;
                case ".rt":
                    cx.Response.ContentType = "text/vnd.rn-realtext";
                    break;
                case ".rtf":
                    cx.Response.ContentType = "application/msword";
                    break;
                case ".rv":
                    cx.Response.ContentType = "video/vnd.rn-realvideo";
                    break;
                case ".sam":
                    cx.Response.ContentType = "application/x-sam";
                    break;
                case ".sat":
                    cx.Response.ContentType = "application/x-sat";
                    break;
                case ".sdp":
                    cx.Response.ContentType = "application/sdp";
                    break;
                case ".sdw":
                    cx.Response.ContentType = "application/x-sdw";
                    break;
                case ".sit":
                    cx.Response.ContentType = "application/x-stuffit";
                    break;
                case ".slb":
                    cx.Response.ContentType = "application/x-slb";
                    break;
                case ".sld":
                    cx.Response.ContentType = "application/x-sld";
                    break;
                case ".slk":
                    cx.Response.ContentType = "drawing/x-slk";
                    break;
                case ".smi":
                    cx.Response.ContentType = "application/smil";
                    break;
                case ".smil":
                    cx.Response.ContentType = "application/smil";
                    break;
                case ".smk":
                    cx.Response.ContentType = "application/x-smk";
                    break;
                case ".snd":
                    cx.Response.ContentType = "audio/basic";
                    break;
                case ".sol":
                    cx.Response.ContentType = "text/plain";
                    break;
                case ".sor":
                    cx.Response.ContentType = "text/plain";
                    break;
                case ".spc":
                    cx.Response.ContentType = "application/x-pkcs7-certificates";
                    break;
                case ".spl":
                    cx.Response.ContentType = "application/futuresplash";
                    break;
                case ".spp":
                    cx.Response.ContentType = "text/xml";
                    break;
                case ".ssm":
                    cx.Response.ContentType = "application/streamingmedia";
                    break;
                case ".sst":
                    cx.Response.ContentType = "application/vnd.ms-pki.certstore";
                    break;
                case ".stl":
                    cx.Response.ContentType = "application/vnd.ms-pki.stl";
                    break;
                case ".stm":
                    cx.Response.ContentType = "text/html";
                    break;
                case ".sty":
                    cx.Response.ContentType = "application/x-sty";
                    break;
                case ".svg":
                    cx.Response.ContentType = "text/xml";
                    break;
                case ".swf":
                    cx.Response.ContentType = "application/x-shockwave-flash";
                    break;
                case ".tdf":
                    cx.Response.ContentType = "application/x-tdf";
                    break;
                case ".tg4":
                    cx.Response.ContentType = "application/x-tg4";
                    break;
                case ".tga":
                    cx.Response.ContentType = "application/x-tga";
                    break;   
                case ".tiff":
                    cx.Response.ContentType = "image/tiff";
                    break;
                case ".tld":
                    cx.Response.ContentType = "text/xml";
                    break;
                case ".top":
                    cx.Response.ContentType = "drawing/x-top";
                    break;
                case ".torrent":
                    cx.Response.ContentType = "application/x-bittorrent";
                    break;
                case ".tsd":
                    cx.Response.ContentType = "text/xml";
                    break;
                case ".txt":
                    cx.Response.ContentType = "text/plain";
                    break;
                case ".uin":
                    cx.Response.ContentType = "application/x-icq";
                    break;
                case ".uls":
                    cx.Response.ContentType = "text/iuls";
                    break;
                case ".vcf":
                    cx.Response.ContentType = "text/x-vcard";
                    break;
                case ".vda":
                    cx.Response.ContentType = "application/x-vda";
                    break;
                case ".vdx":
                    cx.Response.ContentType = "application/vnd.visio";
                    break;
                case ".vml":
                    cx.Response.ContentType = "text/xml";
                    break;
                case ".vpg":
                    cx.Response.ContentType = "application/x-vpeg005";
                    break;
                case ".vsd":
                    cx.Response.ContentType = "application/vnd.visio";
                    break;
                case ".vss":
                    cx.Response.ContentType = "application/vnd.visio";
                    break;
                case ".vst":
                    cx.Response.ContentType = "application/vnd.visio";
                    break;
                case ".vsw":
                    cx.Response.ContentType = "application/vnd.visio";
                    break;
                case ".vsx":
                    cx.Response.ContentType = "application/vnd.visio";
                    break;
                case ".vtx":
                    cx.Response.ContentType = "application/vnd.visio";
                    break;
                case ".vxml":
                    cx.Response.ContentType = "text/xml";
                    break;
                case ".wav":
                    cx.Response.ContentType = "audio/wav";
                    break;
                case ".wax":
                    cx.Response.ContentType = "audio/x-ms-wax";
                    break;
                case ".wb1":
                    cx.Response.ContentType = "application/x-wb1";
                    break;
                case ".wb2":
                    cx.Response.ContentType = "application/x-wb2";
                    break;
                case ".wb3":
                    cx.Response.ContentType = "application/x-wb3";
                    break;
                case ".wbmp":
                    cx.Response.ContentType = "image/vnd.wap.wbmp";
                    break;
                case ".wiz":
                    cx.Response.ContentType = "application/msword";
                    break;
                case ".wk3":
                    cx.Response.ContentType = "application/x-wk3";
                    break;
                case ".wk4":
                    cx.Response.ContentType = "application/x-wk4";
                    break;
                case ".wkq":
                    cx.Response.ContentType = "application/x-wkq";
                    break;
                case ".wks":
                    cx.Response.ContentType = "application/x-wks";
                    break;
                case ".wm":
                    cx.Response.ContentType = "video/x-ms-wm";
                    break;
                case ".wma":
                    cx.Response.ContentType = "audio/x-ms-wma";
                    break;
                case ".wmd":
                    cx.Response.ContentType = "application/x-ms-wmd";
                    break;
                case ".wmf":
                    cx.Response.ContentType = "application/x-wmf";
                    break;
                case ".wml":
                    cx.Response.ContentType = "text/vnd.wap.wml";
                    break;
                case ".wmv":
                    cx.Response.ContentType = "video/x-ms-wmv";
                    break;
                case ".wmx":
                    cx.Response.ContentType = "video/x-ms-wmx";
                    break;
                case ".wmz":
                    cx.Response.ContentType = "application/x-ms-wmz";
                    break;
                case ".wp6":
                    cx.Response.ContentType = "application/x-wp6";
                    break;
                case ".wpd":
                    cx.Response.ContentType = "application/x-wpd";
                    break;
                case ".wpg":
                    cx.Response.ContentType = "application/x-wpg";
                    break;
                case ".wpl":
                    cx.Response.ContentType = "application/vnd.ms-wpl";
                    break;
                case ".wq1":
                    cx.Response.ContentType = "application/x-wq1";
                    break;
                case ".wr1":
                    cx.Response.ContentType = "application/x-wr1";
                    break;
                case ".wri":
                    cx.Response.ContentType = "application/x-wri";
                    break;
                case ".wrk":
                    cx.Response.ContentType = "application/x-wrk";
                    break;
                case ".ws":
                    cx.Response.ContentType = "application/x-ws";
                    break;
                case ".ws2":
                    cx.Response.ContentType = "application/x-ws";
                    break;
                case ".wsc":
                    cx.Response.ContentType = "text/scriptlet";
                    break;
                case ".wsdl":
                    cx.Response.ContentType = "text/xml";
                    break;
                case ".wvx":
                    cx.Response.ContentType = "video/x-ms-wvx";
                    break;
                case ".xdp":
                    cx.Response.ContentType = "application/vnd.adobe.xdp";
                    break;
                case ".xdr":
                    cx.Response.ContentType = "text/xml";
                    break;
                case ".xfd":
                    cx.Response.ContentType = "application/vnd.adobe.xfd";
                    break;
                case ".xfdf":
                    cx.Response.ContentType = "application/vnd.adobe.xfdf";
                    break;
                case ".xhtml":
                    cx.Response.ContentType = "text/html";
                    break;
                case ".xls":
                    cx.Response.ContentType = "application/vnd.ms-excel";
                    break;                
                case ".xlw":
                    cx.Response.ContentType = "application/x-xlw";
                    break;
                case ".xml":
                    cx.Response.ContentType = "text/xml";
                    break;
                case ".xpl":
                    cx.Response.ContentType = "audio/scpls";
                    break;
                case ".xq":
                    cx.Response.ContentType = "text/xml";
                    break;
                case ".xql":
                    cx.Response.ContentType = "text/xml";
                    break;
                case ".xquery":
                    cx.Response.ContentType = "text/xml";
                    break;
                case ".xsd":
                    cx.Response.ContentType = "text/xml";
                    break;
                case ".xsl":
                    cx.Response.ContentType = "text/xml";
                    break;
                case ".xslt":
                    cx.Response.ContentType = "text/xml";
                    break;
                case ".xwd":
                    cx.Response.ContentType = "application/x-xwd";
                    break;
                case ".x_b":
                    cx.Response.ContentType = "application/x-x_b";
                    break;
                case ".sis":
                    cx.Response.ContentType = "application/vnd.symbian.install";
                    break;
                case ".sisx":
                    cx.Response.ContentType = "application/vnd.symbian.install";
                    break;
                case ".x_t":
                    cx.Response.ContentType = "application/x-x_t";
                    break;
                case ".ipa":
                    cx.Response.ContentType = "application/vnd.iphone";
                    break;
                case ".apk":
                    cx.Response.ContentType = "application/vnd.android.package-archive";
                    break;
                case ".xap":
                    cx.Response.ContentType = "application/x-silverlight-app";
                    break;
                default:
                    break;
            }
        }
    }
}
