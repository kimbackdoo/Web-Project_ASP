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
    public partial class Reply : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnReply_Click(object sender, ImageClickEventArgs e)
        {
            // 현 게시물의 ref_id, inner_id, depth 가져오기
            string selectString = "SELECT ref_id, inner_id, depth FROM board WHERE ";
            selectString += "serial_no=" + Request["sn"];

            int refId = 0;
            int innerId = 0;
            int depth = 0;

            DBConn conn = new DBConn();
            SqlDataReader dr = conn.ExecuteReader(selectString);
            if (dr.Read())
            {
                refId = (int)dr["ref_id"];
                innerId = (int)dr["inner_id"];
                depth = (int)dr["depth"];
            }
            dr.Close();

            // 현 게시물과 같은 글을 참조하는 글 중에서 현 게시물 이후의 inner_id를 1 증가
            string updateString = "UPDATE board SET inner_id=inner_id+1 WHERE ";
            updateString += "ref_id=" + refId.ToString();
            updateString += " AND inner_id > " + innerId.ToString();
            conn.ExecuteNonQuery(updateString);

            // 답변 글 저장
            string insertString = "INSERT INTO board (writer, password, title, message, ";
            insertString += "ref_id, inner_id, depth, read_count, del_flag, reg_date) ";
            insertString += "VALUES(@writer, @password, @title, @message, @ref_id, @inner_id, ";
            insertString += "@depth, 0, 'N', GETDATE())";

            string hashedPassword =
                FormsAuthentication.HashPasswordForStoringInConfigFile(txtPassword.Text, "sha1");

            SqlCommand cmd = new SqlCommand(insertString, conn.GetConn());
            cmd.Parameters.AddWithValue("@writer", txtWriter.Text);
            cmd.Parameters.AddWithValue("@password", hashedPassword);
            cmd.Parameters.AddWithValue("@title", txtTitle.Text);
            cmd.Parameters.AddWithValue("@message", txtMessage.Text);
            cmd.Parameters.AddWithValue("@ref_id", refId);
            cmd.Parameters.AddWithValue("@inner_id", ++innerId);
            cmd.Parameters.AddWithValue("@depth", ++depth);

            try
            {
                cmd.ExecuteNonQuery();
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