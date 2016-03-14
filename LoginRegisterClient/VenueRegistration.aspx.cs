using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class VenueRegistration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        VenueLoginServiceReference.STLoginServiceClient src =
            new VenueLoginServiceReference.STLoginServiceClient();
        VenueLoginServiceReference.VenueLite vLite =
            new VenueLoginServiceReference.VenueLite();

        vLite.VenueName = VenueNameTextBox.Text;
        vLite.venueEmail = EmailTextBox.Text;
        vLite.venueAddress = AddressTextBox.Text;
        vLite.venueCity = CityTextBox.Text;
        vLite.venueState = StateTextBox.Text;
        vLite.venueZipCode = ZipTextBox.Text;
        vLite.venuePhone = PhoneTextBox.Text;
        vLite.venueWebPage = WebPageTextBox.Text;
        if (AgeTextBox.Text != null)
        {
            vLite.venueAgeRestriction = int.Parse(AgeTextBox.Text.ToString());
        }
        vLite.venueLoginUserName = UsernameTextBox.Text;
        vLite.venuLoginPasswordPlain = AddressTextBox.Text;


        int result = src.VenueRegistration(vLite);

        if(result != -1)
        {
            ResultLabel.Text = "Successfully Registered";
        }
        else
        {
            ResultLabel.Text = "Registration Failed";
        }
    }
}