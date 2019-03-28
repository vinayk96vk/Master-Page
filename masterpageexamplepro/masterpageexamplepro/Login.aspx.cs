using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CustomerBLlib;
namespace masterpageexamplepro
{
    public partial class Login : System.Web.UI.Page
    {
        CustomerBL bl = new CustomerBL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            string role = bl.CheckLogin(Login1.UserName, Login1.Password);
            if (role == null)
                e.Authenticated = false;
            else if (role == "user")
            {
                e.Authenticated = true;
                Response.Redirect("Home.aspx");
            }
            else
            {
                e.Authenticated = true;
                Response.Redirect("adminhome.aspx");
            }
        }
    }
}