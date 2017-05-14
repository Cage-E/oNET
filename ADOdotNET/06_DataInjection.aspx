<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="06_DataInjection.aspx.cs" Inherits="ADOdotNET.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Get employee info" />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Employee name empty!"></asp:RequiredFieldValidator>
    
    </div>
    </form>
</body>
</html>
