using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Team_Project
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblCounter.Text = "총 방문자 수 : &nbsp;&nbsp;&nbsp;" + Application["counter"] + " 명";
            lblActiveCounter.Text = "현재 접속자 수 : &nbsp;&nbsp;" + Application["activecounter"] + " 명";
        }
    }
}