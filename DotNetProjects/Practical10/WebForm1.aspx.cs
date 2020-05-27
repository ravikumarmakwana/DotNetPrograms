﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical10
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        static System.Drawing.Color color;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Panel1.Visible = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Panel1.Visible == true)
            {
                Panel1.Visible = false;
            }
            else
            {
                Panel1.Visible = true;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            color = System.Drawing.Color.Yellow;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            color = System.Drawing.Color.Red;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            color = System.Drawing.Color.Blue;
        }

        protected void btnSetColor_Click(object sender, EventArgs e)
        {
            lblChangingColor.ForeColor = color;
            Panel1.Visible = false;
        }
    }
}