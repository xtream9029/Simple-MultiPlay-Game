using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Server.Data
{
    //일련의 설정 파일들을 관리
    [Serializable]
    public class ServerConfig
    {
        public string dataPath;
    }

    public class ConfigManager
    {
        public static ServerConfig Config { get; private set; }        

        public static void LoadConfig()
        {
            string text = File.ReadAllText("config.json");
            Config= Newtonsoft.Json.JsonConvert.DeserializeObject<ServerConfig>(text);//json 파싱
        }

    }
}
