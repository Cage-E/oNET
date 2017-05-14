<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="jQueryWebForms.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-3.1.1.js"></script>
    <script type="text/javascript">
        $(window).on('load',function () {
            $('#div1').html("Height = " + document.getElementById('image1').height
                + "<br/>" + "Width = " + $('#Image1').width())
        });
    </script>
</head>
<body>
    <div id="div1"></div>
    <div>
        <img src="image.gif" id="image1"/>
    </div>
    </form>
</body>
</html>
