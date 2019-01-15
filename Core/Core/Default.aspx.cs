using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Core
{
    public partial class LogIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnLog_Click(object sender, EventArgs e)
        {
            if(TxtUser.Text == "admin001" && TxtPassword.Text == "pass001")
            {
                Response.Redirect("~/adminPage.aspx");
            } else
            {
                Response.Write("Log in failed");
            }
        }
    }
}