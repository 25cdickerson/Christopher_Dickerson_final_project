using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Christopher_Dickerson_final_project
{
    public partial class WebForm1 : System.Web.UI.Page
    {
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
    }
}