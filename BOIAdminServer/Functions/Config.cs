using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace GetOnline.Functions
{
    class Config
    {
        public static Boolean UseMySQL;
        public static String MyIP;
        public static String MyPort;
        public static String MyDatabase;
        public static String MyUser;
        public static String MyPassword;
        public static String MyTable;
        public static Boolean Trigger ;
        public static String ManagePathLog;
        public static int Timer;

        public static void Load()
        {
            XElement ConfigXml;
            try
            {
                ConfigXml = XElement.Load("GetOnlineCfg.xml");
            }
            catch (Exception e)
            {
                //Log.WriteError("Não foi possivel Ler o Arquivo de Config.xml");
                Log.WriteInfo("Creating GetOnlineCfg.xml");

                try { CreateConfig(); }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }

                Load();
                return;
            }

            ConfigXml = XElement.Load("GetOnlineCfg.xml");

            try
            {
                XElement Cfg = ConfigXml.Element("Config");
                Config.ManagePathLog = ConfigXml.Element("ManageLogPath").Value;
                Config.Timer = int.Parse(ConfigXml.Element("TimerCheck").Value);


                XElement MySQL = ConfigXml.Element("MySQL");
                Config.UseMySQL = Boolean.Parse(MySQL.Attribute("Use").Value);
                Config.MyIP = MySQL.Element("IP").Value;
                Config.MyPort = MySQL.Element("Port").Value;
                Config.MyDatabase = MySQL.Element("Database").Value;
                Config.MyPassword = MySQL.Element("Password").Value;
                Config.MyUser = MySQL.Element("User").Value;
                Config.MyTable = MySQL.Element("Table").Value;


            }
            catch (Exception e)
            {
                CreateConfig();
                //Log.WriteError(e.Message);
                //throw new Exception(e.ToString());
                //Load();
            }
        }
        public static void CreateConfig()
        {
            XElement NewCfg = new XElement("Config",
                new XElement("ManageLogPath", "Select any managelog"),
                new XElement("TimerCheck", "1000"),
                new XElement("MySQL",
                    new XAttribute("Use", "true"),
                    new XElement("Use", "true"),
                    new XElement("IP", "mysql ip"),
                    new XElement("Port", "3306"),
                    new XElement("Database", "shengui"),
                    new XElement("Password", "password"),
                    new XElement("User", "user"),
                    new XElement("Table", "online_memb")
                    )
                );


            NewCfg.Save("GetOnlineCfg.xml");
        }

        public static void Save(String Value, String SubSubSection, String SubSection)
        {
            XElement ConfigXml = XElement.Load("GetOnlineCfg.xml");
            if (SubSection != null)
            {

                XElement child = ConfigXml.Element(SubSection);
                child.Element(SubSubSection).Remove();
                child.Add(new XElement( SubSubSection, Value));
                ConfigXml.Save("GetOnlineCfg.xml");
            }
            else if(SubSubSection != null)
            {

                ConfigXml.Element(SubSubSection).Remove();
                ConfigXml.Add(new XElement(SubSubSection, Value));
                ConfigXml.Save("GetOnlineCfg.xml");
            }

        }

    }
}
