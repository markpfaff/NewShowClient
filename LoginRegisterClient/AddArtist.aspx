<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddArtist.aspx.cs" Inherits="AddArtist" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <table>
         <tr>
            <td>Add Artist</td>
         </tr>
         <tr>
             <td>Artist Name</td>
             <td>
                <asp:TextBox ID="ArtistNameTextBox" runat="server"></asp:TextBox>
            </td>
         </tr>
         <tr>
            <td>Artist Email</td>
            <td>
                <asp:TextBox ID="AristEmailTextBox" runat="server"></asp:TextBox>
            </td>
          </tr>
          <tr>
            <td>Artist Web</td>
            <td>
                <asp:TextBox ID="ArtistWebTextBox" runat="server"></asp:TextBox>
            </td>

        </tr>
        <tr>
            <td>Artist Date</td>
            <td>
                <asp:Calendar ID="ArtistDateCalendar" runat="server"></asp:Calendar>
            </td>

        </tr>
            <tr>
                  <td>
                    <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" />
                    <asp:Label ID="ResultLabel" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            </table>
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="AddShow.aspx">Add Show</asp:HyperLink>

    </div>
    </form>
</body>
</html>
