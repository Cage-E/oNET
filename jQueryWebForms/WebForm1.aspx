<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="jQueryWebForms._01_WebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="Scripts/jquery-3.1.1.min.js"></script>
    <script type="text/javascript">
        $(function () {
            $('#Button1').click(function () {
                alert('Hi')
            });
        });
    </script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <input id="Button1" type="button" value="button" />
    </div>
    </form>
</body>
</html>
