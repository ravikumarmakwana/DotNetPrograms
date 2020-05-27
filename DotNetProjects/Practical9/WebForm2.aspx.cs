using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical9
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["username"].Length!=0)
            {
                label.Text = "Welcome " +Request.QueryString["username"];
            }
            else
            {
                label.Text = "Empty String";
            }
        }
    }
}