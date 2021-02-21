using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentRatingSystemClient
{
    public partial class User : System.Web.UI.Page
    {
        StudentSystemServiceReferece.StudentSystemClient client;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (SessionManage.sessionId == -1)
            {
                Response.Redirect("Login.aspx");
            }
            client = new StudentSystemServiceReferece.StudentSystemClient();
            User_Rate.Text = "";
            IEnumerable<StudentSystemServiceReferece.Student> data = client.ShowStudent();
            if (data.Count() == 0)
            {
                User_Rate.ForeColor = System.Drawing.Color.Green;
                User_Rate.Text = "No Data Available";
            }
            GridView1.DataSource = data;
            GridView1.DataBind();
        }

        protected void Provide_Rating_Click(object sender, EventArgs e)
        {
            Response.Redirect("User_rate.aspx");
        }

        protected void Student_Click(object sender, EventArgs e)
        {
            Response.Redirect("User.aspx");
        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            SessionManage.sessionId = -1;
            Response.Redirect("Login.aspx");
        }
    }
}