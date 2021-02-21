using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentRatingSystemClient
{
    public partial class Admin_User_Check : System.Web.UI.Page
    {
        StudentSystemServiceReferece.StudentSystemClient client;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (SessionManage.sessionId == -1)
            {
                Response.Redirect("Login.aspx");
            }
            client = new StudentSystemServiceReferece.StudentSystemClient();
            Admin_User_Label.Text = "";
            IEnumerable<StudentSystemServiceReferece.SystemUser> data = client.ShowUser();
            if (data.Count() == 0)
            {
                Admin_User_Label.ForeColor = System.Drawing.Color.Green;
                Admin_User_Label.Text = "No Data Available";
            }
            GridView1.DataSource = data;
            GridView1.DataBind();
        }

        protected void Student__Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin.aspx");
        }

        protected void User__Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin_User_Check.aspx");
        }

        protected void Student_Rating__Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin_User_Rating.aspx");
        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            SessionManage.sessionId = -1;
            Response.Redirect("Login.aspx");
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string id = GridView1.Rows[e.RowIndex].Cells[2].Text;
            Console.WriteLine("\n\ndeleted id:" + id);
            int id_ = Convert.ToInt32(id);
            string result = client.DeleteUser(id_);
            Admin_User_Label.Text = result;
            GridView1.DataSource = client.ShowUser();
            GridView1.DataBind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
         {
             string id = GridView1.Rows[e.RowIndex].Cells[2].Text;
             int id_ = Convert.ToInt32(id);

             if (TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "")
             {
                 Admin_User_Label.ForeColor = System.Drawing.Color.Red;
                 Admin_User_Label.Text = "Fill All TextBoxs With New Values To Update Row";
                 return;
             }
             StudentSystemServiceReferece.SystemUser Student = new StudentSystemServiceReferece.SystemUser();
             Student.User_Name = TextBox2.Text.ToUpper();
             Student.User_Password = TextBox1.Text.ToUpper();
             Student.User_Designation = TextBox3.Text.ToUpper();
            
             string result = client.UpdateUser(id_, Student);
             Admin_User_Label.ForeColor = System.Drawing.Color.Green;
             Admin_User_Label.Text = result;
             GridView1.DataSource = client.ShowUser();
             GridView1.DataBind();
         }
    }
}