using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Data.SqlClient;

namespace Team_Project.Board
{
    public partial class CheckPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["mode"] == "edit")
            {
                btnEditOrDelete.ImageUrl = "~/images/btn_edit.gif";
            }
            else
            {
                btnEditOrDelete.ImageUrl = "~/images/btn_delete.gif";
            }
        }

        protected void btnEditOrDelete_Click(object sender, ImageClickEventArgs e)
        {
            string hashedPassword =
                FormsAuthentication.HashPasswordForStoringInConfigFile(txtPassword.Text, "sha1");

            string selectString = "SELECT * FROM board WHERE serial_no=";
            selectString += Request["sn"] + " AND password='" + hashedPassword + "'";

            DBConn conn = new DBConn();
            SqlDataReader dr = conn.ExecuteReader(selectString);

            if (dr.Read())
            {
                if (Request["mode"] == "edit")
                {
                    Response.Redirect("~/Board/Edit.aspx?sn=" + Request["sn"]);
                }
                else
                {
                    Response.Redirect("~/Board/Delete.aspx?sn=" + Request["sn"]);
                }
            }
            else
            {
                lblErrorMessage.Text = "비밀번호가 일치하지 않습니다. 다시 한 번 입력해주세요.";
            }

            dr.Close();
            conn.Close();

        }
    }
}