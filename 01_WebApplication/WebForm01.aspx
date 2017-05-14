<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm01.aspx.cs" Inherits="_01_WebApplication.WebForm01" %>

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
                <td>First Name</td>
                <td>
                    <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                &nbsp;<asp:Label ID="lblFristName" runat="server" Text="" ForeColor="Red"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Last Name</td>
                <td>
                    <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                &nbsp;<asp:Label ID="lblLastName" runat="server" Text="" ForeColor="Red"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Email</td>
                <td>
                    <asp:TextBox ID="Email" runat="server"></asp:TextBox>
                &nbsp;<asp:Label ID="lblEmail" runat="server" Text="" ForeColor="Red"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2">

                <asp:Button ID="btnSubmit" runat="server" Text="Submit" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
