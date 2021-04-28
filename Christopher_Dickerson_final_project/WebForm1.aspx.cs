using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Christopher_Dickerson_final_project
{
    public partial class WebForm1 : System.Web.UI.Page
    { 
        int count = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            BSubmit.Click += new EventHandler(this.sClick);
            BClear.Click += new EventHandler(this.clrClick);
        }

        protected void sClick(object sender, EventArgs e)
        {
            if (validName.IsValid && validEmailRF.IsValid && validEmailRE.IsValid &&
                validSubject.IsValid && validMath.IsValid && validMessage.IsValid && 
                Int16.Parse(TMath.Text) == 15)
            {
                LInfo.Visible = true;
                LInfo.Text = "The Information Entered: <br />Name: " + TName.Text +
                    "<br />Email: " + TEmail.Text + "<br />Website: " + TWebsite.Text +
                    "<br />Subject: " + TSubject.Text + "<br />Message: " + TMessage.Text;
                TName.Text = "";
                TEmail.Text = "";
                TWebsite.Text = "";
                TSubject.Text = "";
                TMessage.Text = "";

                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\chris\source\repos\Christopher_Dickerson_final_project\Christopher_Dickerson_final_project\App_Data\Database1.mdf;Integrated Security=True"))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = "insert into [Table] (Id, Name, Email, Website, Subject, Message) values(@Id, @Name, @Email, @Website, @Subject, @Message)";
                        cmd.Parameters.AddWithValue("@Id", count);
                        cmd.Parameters.AddWithValue("@Name", TName.Text);
                        cmd.Parameters.AddWithValue("@Email", TEmail.Text);
                        cmd.Parameters.AddWithValue("@Website", TWebsite.Text);
                        cmd.Parameters.AddWithValue("@Subject", TSubject.Text);
                        cmd.Parameters.AddWithValue("@Message", TMessage.Text);
                        cmd.Connection = con;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        count++;
                    }
                }
            }
        }

        protected void clrClick(object sender, EventArgs e)
        {
            TName.Text = "";
            TEmail.Text = "";
            TWebsite.Text = "";
            TSubject.Text = "";
            TMessage.Text = "";
            TMath.Text = "";
            LInfo.Text = "";
            LInfo.Visible = false;
        }

        protected void BSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}