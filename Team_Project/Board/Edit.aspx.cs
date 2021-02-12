using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Team_Project.Board
{
    public partial class Edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string selectString = "SELECT * FROM board WHERE serial_no=" + Request["sn"];

                DBConn conn = new DBConn();
                SqlDataReader dr = conn.ExecuteReader(selectString);

                if (dr.Read())
                {
                    txtWriter.Text = dr["writer"].ToString();
                    txtTitle.Text = dr["title"].ToString();
                    txtMessage.Text = dr["message"].ToString();
                }

                dr.Close();
                conn.Close();
            }
        }

        protected void btnEdit_Click(object sender, ImageClickEventArgs e)
        {
            string updateString = "UPDATE board SET writer=@writer, ";
            updateString += "title=@title, message=@message ";
            updateString += "WHERE serial_no=" + Request["sn"];

            DBConn conn = new DBConn();
            SqlCommand cmd = new SqlCommand(updateString, conn.GetConn());

            cmd.Parameters.AddWithValue("@writer", txtWriter.Text);
            cmd.Parameters.AddWithValue("@title", txtTitle.Text);
            cmd.Parameters.AddWithValue("@message", txtMessage.Text);

            cmd.ExecuteNonQuery();

            conn.Close();

            Response.Redirect("~/Board/List.aspx");
        }
    }
}