using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Team_Project.Board
{
    public partial class Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DBConn conn = new DBConn();
            // 삭제하고자 하는 글의 참조 번호 찾기(답변이 아닌 경우 자신을 참조)
            string selectRefId = "SELECT ref_id FROM board WHERE serial_no=" + Request["sn"];
            string refString = conn.ExecuteScalar(selectRefId).ToString();

            // 참조 번호가 같으면서 삭제되지 않은 글 수를 얻음
            string selectString = "SELECT COUNT(*) FROM board WHERE ref_id=";
            selectString += refString;
            selectString += " AND del_flag <> 'Y'";
            int count = (int)conn.ExecuteScalar(selectString);
            // 참조 번호가 같은 삭제되지 않은 글이 있으면 del_flag 만 갱신
            if (count > 1)
            {
                string updateString = "UPDATE board SET del_flag='Y' WHERE serial_no=";
                updateString += Request["sn"];
                conn.ExecuteNonQuery(updateString);
            }
            else
            {
                string deleteString = "DELETE FROM board WHERE ref_id=" + refString;
                conn.ExecuteNonQuery(deleteString);
            }

            conn.Close();
            Response.Redirect("~/Board/List.aspx");
        }
    }
}