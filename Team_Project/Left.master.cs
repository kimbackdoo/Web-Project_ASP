using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace Team_Project
{
    public partial class Left : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string counter = Application["counter"].ToString();
            for (int i = 0; i < counter.Length; i++)
            {
                Image img = new Image();
                img.ImageUrl = "images/" + counter[i] + ".bmp";
                img.Height = 30;
                img.Width = 30;
                pnlCounter.Controls.Add(img);
            }
        }
    }
}