<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm12.aspx.cs" Inherits="_01_WebApplication.WebForm12" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script type="text/javascript">
        function ValidateEmail() {
            var emailTextBox = document.getElementById("txtEmail");
            var email = emailTextBox.value;
            var emailRegEx = /^(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
            txtEmail.style.color = "white";
            if (emailRegEx.test(email)) {
                emailTextBox.style.backgroundColor = "green";
            }
            else {
                emailTextBox.style.backgroundColor = "red";
            }
        }
    </script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="border: 1px">
                <tr>
                    <td>Email</td>
                    <td>
                        <input type="text" id="txtEmail" onkeyup="ValidateEmail()"/>
                        <%--<asp:TextBox ID="txtEmail" runat="server"></asp:TextBox on>--%>
                        <%--<asp:Label ID="lblFirst" runat="server" Text=""></asp:Label>--%>
                    </td>
                </tr>
                <tr>
                    <td>Email Part</td>
                    <td>
                        <asp:TextBox ID="txtSecondNumber runat="server"></asp:TextBox>
                        <%--<asp:Label ID="lblSecond" runat="server" Text=""></asp:Label>--%>
                    </td>
                </tr>
                <tr>
                    <td>Result</td>
                    <td>
                        <asp:TextBox ID="txtResult" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClientClick="Add()" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
