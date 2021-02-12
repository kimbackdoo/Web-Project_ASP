using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Team_Project.Board
{
    public partial class List : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected string ShowDepth(int depth)
        {
            string returnString = "";
            for (int i = 0; i < depth; i++)
            {
                returnString += "&nbsp;&nbsp;&nbsp;";
            }
            return returnString;
        }

        protected string ShowReplyIcon(int innerId)
        {
            string returnString = "";

            if (innerId != 0)
            {
                returnString += "<img src='/WebEx/13/images/reply_icon.gif' />";
            }
            return returnString;
        }

        protected string ShowTitle(string serialNo, string title, string delFlag)
        {
            string returnString = "";
            // del_flag 필드 값이 N인 경우, 즉 삭제되지 않은 게시물
            if (delFlag == "N")
            {
                returnString += "<a href='Read.aspx?sn=" + serialNo;
                returnString += "' class='a01'>" + title + "</a>";
            }
            // del_flag 필드 값이 Y인 경우, 즉 삭제된 게시물
            else
            {
                returnString += "삭제된 게시물입니다.";
            }
            return returnString;
        }

        protected string ShowDate(DateTime regDate)
        {
            return string.Format("{0:yyyy-MM-dd}", regDate);
        }
    }
}