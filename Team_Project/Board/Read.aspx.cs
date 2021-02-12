using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Team_Project.Board
{
    public partial class Read : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // 조회 수 증가
                string updateString = "UPDATE board SET read_count=read_count+1 ";
                updateString += "WHERE serial_no=" + Request["sn"];

                // 쿼리 문자열로 받은 게시물 ID에 해당하는 데이터 행 선택
                string selectString = "SELECT * FROM board WHERE serial_no=" + Request["sn"];

                DBConn conn = new DBConn();
                conn.ExecuteNonQuery(updateString);
                SqlDataReader dr = conn.ExecuteReader(selectString);

                if (dr.Read())
                {
                    lblWriter.Text = dr["writer"].ToString();
                    lblRegDate.Text = string.Format("{0:yyyy-MM-dd}", (DateTime)dr["reg_date"]);
                    lblTitle.Text = dr["serial_no"].ToString() + ". ";
                    lblTitle.Text += dr["title"].ToString();
                    lblTitle.Text += "(조회 : " + dr["read_count"].ToString() + ")";
                    txtMessage.Text = dr["message"].ToString();

                    // 수정, 답변, 삭제에 필요한 게시물 ID를 쿼리 문자열로 넘김
                    btnEdit.PostBackUrl =
                        "~/Board/CheckPassword.aspx?mode=edit&sn=" + dr["serial_no"].ToString();
                    btnReply.PostBackUrl =
                        "~/Board/Reply.aspx?sn=" + dr["serial_no"].ToString();
                    btnDelete.PostBackUrl =
                        "~/Board/CheckPassword.aspx?mode=del&sn=" + dr["serial_no"].ToString();
                }

                dr.Close();
                conn.Close();
            }
        }
    }
}