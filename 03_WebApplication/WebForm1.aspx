<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_03_WebApplication.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" lang="ja">
        function ValidateForm() {
            var ret = true;
            if (document.getElementById("txtFirstName").valueOf() == "") {
                document.getElementById("lblFirstName").textContent = "First name is required.";
                ret = false;
            }
            else {
                docu.getElementById("lblFirstName").textContent = ""
            }
            if (document.getElementById("txtLastName").valueOf() == "") {
                document.getElementById("lblLastName").textContent = "Last name is required.";
                ret = false;
            }
            else {
                docu.getElementById("lblLastName").textContent = ""
            }
            if (document.getElementById("txtEmail").valueOf() == "") {
                document.getElementById("lblEmail").textContent = "Email is required.";
                ret = false;
            }
            else {
                docu.getElementById("lblEmail").textContent = ""
            }
            return ret;
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="border: 1px solid black; font-family: Arial">
                <tr>
                    <td>
                        <b>First Name</b>
                    </td>
                    <td>
                        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                        <asp:Label ID="lblFirstName" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <b>Last Name</b>
                    </td>
                    <td>
                        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                        <asp:Label ID="lblLastName" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <b>Email</b>
                    </td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                        <asp:Label ID="lblEmail" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" OnClientClick="VaildateForm" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
