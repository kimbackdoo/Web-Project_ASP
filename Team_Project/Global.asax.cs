using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.UI;
using System.IO;

namespace Team_Project
{
    public class Global : System.Web.HttpApplication
    {
        public int Counter {
            get {
                // Counter.txt 파일의 물리적 경로를 얻기 위해 Server 객체의 MapPath 메서드 사용
                string filePath = Server.MapPath(@"App_Data\Counter.txt");
                FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read,
                                                                    FileShare.ReadWrite);
                StreamReader sr = new StreamReader(fs);
                string readString = sr.ReadLine();
                int counter = int.Parse(readString);

                sr.Close();
                fs.Close();

                return counter;
            }

            set {
                string filePath = Server.MapPath(@"App_Data\Counter.txt");
                FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Write,
                                                                    FileShare.ReadWrite);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(value.ToString());

                sw.Close();
                fs.Close();
            }
        }

        protected void Application_Start(object sender, EventArgs e)
        {
            ScriptManager.ScriptResourceMapping.AddDefinition("jquery", new ScriptResourceDefinition {
                Path = "~/script/jquery-3.1.1.js"
            });

            Application["counter"] = Counter;
            Application["activecounter"] = 0;
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Application.Lock();
            Application["counter"] = 1 + (int)Application["counter"];
            Counter = (int)Application["counter"];
            Application["activecounter"] = 1 + (int)Application["activecounter"];
            Application.UnLock();
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {
            Application.Lock();
            Application["activecounter"] = (int)Application["activecounter"] - 1;
            Application.UnLock();
        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}