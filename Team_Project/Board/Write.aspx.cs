using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Security;

namespace Team_Project.Board
{
    public partial class Write : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnWrite_Click(object sender, ImageClickEventArgs e)
        {
            string insertString = "INSERT INTO board (writer, password, title, message, ";
            insertString += "ref_id, inner_id, depth, read_count, del_flag, reg_date) ";
            insertString += "VALUES(@writer, @password, @title, @message, 0, 0, 0, 0, ";
            insertString += "'N', GETDATE())";

            string updateString = "UPDATE board SET ref_id = serial_no WHERE ref_id = 0";

            string hashedPassword =
                FormsAuthentication.HashPasswordForStoringInConfigFile(txtPassword.Text, "sha1");

            DBConn conn = new DBConn();
            SqlCommand cmd = new SqlCommand(insertString, conn.GetConn());
            cmd.Parameters.AddWithValue("@writer", txtWriter.Text);
            cmd.Parameters.AddWithValue("@password", hashedPassword);
            cmd.Parameters.AddWithValue("@title", txtTitle.Text);
            cmd.Parameters.AddWithValue("@message", txtMessage.Text);

            try
            {
                cmd.ExecuteNonQuery();
                conn.ExecuteNonQuery(updateString);
            }
            catch (Exception error)
            {
                Response.Write(error.ToString());
            }
            finally
            {
                conn.Close();
            }

            Response.Redirect("~/Board/List.aspx");
        }
    }
}