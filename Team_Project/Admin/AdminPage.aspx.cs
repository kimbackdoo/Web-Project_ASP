using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data;

namespace Team_Project.Admin
{
    public partial class AdminPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                dlstMember.DataSource = dsrcMember;
                dlstMember.DataBind();
            }
        }

        protected void dlstMember_ItemCommand(object source, DataListCommandEventArgs e)
        {
            dlstMember.SelectedIndex = e.Item.ItemIndex;
            dlstMember.DataSource = dsrcMember;
            dlstMember.DataBind();
        }

        protected void dlstMember_CancelCommand(object source, DataListCommandEventArgs e)
        {
            dlstMember.EditItemIndex = -1;
            dlstMember.DataSource = dsrcMember;
            dlstMember.DataBind();
        }

        protected void dlstMember_EditCommand(object source, DataListCommandEventArgs e)
        {
            dlstMember.EditItemIndex = e.Item.ItemIndex;
            dlstMember.DataSource = dsrcMember;
            dlstMember.DataBind();
        }

        protected void dlstMember_DeleteCommand(object source, DataListCommandEventArgs e)
        {
           
            string connectionString = WebConfigurationManager.ConnectionStrings["CS_aspnet"].ConnectionString;
            string deleteSQL = "DELETE FROM aspnet_Membership";
            deleteSQL += " WHERE UserId=@UserId";

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(deleteSQL,conn);

            Label memInfo = (Label)e.Item.FindControl("lblUserId");
            
            cmd.Parameters.AddWithValue("@UserId", memInfo.Text);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            Response.Redirect(Request.RawUrl);
        }

        protected void dlstMember_UpdateCommand(object source, DataListCommandEventArgs e)
        {
            string connectionString = WebConfigurationManager.ConnectionStrings["CS_aspnet"].ConnectionString;
            string updateSQL = "UPDATE aspnet_Membership";
            updateSQL += " SET Email=@Email WHERE UserId=@UserId";

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(updateSQL, conn);

            TextBox txtPasswordQ = (TextBox)e.Item.FindControl("tbEmail");
            Label memInfo = (Label)e.Item.FindControl("lblUserId");

            cmd.Parameters.AddWithValue("@Eamil", txtPasswordQ.Text);
            cmd.Parameters.AddWithValue("@UserId", memInfo.Text);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            Response.Redirect(Request.RawUrl);
        }
    }
}