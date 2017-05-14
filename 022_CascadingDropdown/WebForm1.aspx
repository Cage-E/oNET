<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_022_CascadingDropdown.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DropDownList ID="DropDownContinents" runat="server" DataTextField="ContinentName" DataValueField="ContinentId" OnSelectedIndexChanged="DropDownContinents_SelectedIndexChanged" AutoPostBack="true">
            
        </asp:DropDownList>
        <br />
        <br />
        <asp:DropDownList ID="DropDownCountries" runat="server" DataTextField="CountryName" DataValueField="CountryId" OnSelectedIndexChanged="DropDownCountries_SelectedIndexChanged" AutoPostBack="true">
        </asp:DropDownList>
        <br />
        <br />
        <asp:DropDownList ID="DropDownCities" runat="server" DataTextField="CityName" DataValueField="CityId">
        </asp:DropDownList>
    
    </div>
    </form>
</body>
</html>
