﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void LoginButton_Click(object sender, EventArgs e)
    {
        VenueLogin();
    }

    protected void VenueLogin()
    {
        LoginRegisterServiceReference.STLoginServiceClient src =
            new LoginRegisterServiceReference.STLoginServiceClient();
        int key = src.VenueLogin(PasswordTextbox.Text, UserNameTextbox.Text);
        if(key != -1)
        {
            ErrorLabel.Text = "Welcome";
            Session["userKey"] = key;
            Response.Redirect("AddShow.aspx");
        }
        else
        {
            ErrorLabel.Text = "Login Fail";
        }
    }
}