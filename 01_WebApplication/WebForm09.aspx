<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm09.aspx.cs" Inherits="_01_WebApplication.WebForm09" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script type="text/javascript">
        function Add() {
            var first = parseFloat(document.getElementById("txtFirstNumber").value);
            var second = parseFloat(document.getElementById("txtSecondNumber").value);

            if (isNaN(first) || isNaN(second)) {
                alert("Please enter a number.");
                return
            }

            if (!(isNaN(first) && isNaN(second))) {

            var result = first + second;
            document.getElementById("txtResult").value = result;
            }
            };
    </script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="border:1px">
            <tr>
                <td>First number</td>
                <td>
                    <asp:TextBox ID="txtFirstNumber" runat="server"></asp:TextBox>
                    <asp:Label ID="lblFirst" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Second Number</td>
                <td>
                    <asp:TextBox ID="txtSecondNumber" runat="server"></asp:TextBox>
                    <asp:Label ID="lblSecond" runat="server" Text=""></asp:Label>
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
                <asp:Button ID="btnAdd" runat="server" Text="Add" OnClientClick="Add()"/>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
