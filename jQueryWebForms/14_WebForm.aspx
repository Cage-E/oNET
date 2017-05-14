<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="14_WebForm.aspx.cs" Inherits="jQueryWebForms._14_WebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="Scripts/jquery-3.1.1.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $('#selectCountries').change(function () {
                var selectedOptions = $('#selectCountries option:selected');
                var resultString = '';
                selectedOptions.each(function () {
                    resultString += 'Value= ' + $(this).val() + ', Text= ' + $(this).text();
                })
                $('#divResult').html(resultString);
            });
        });
    </script>
    <title></title>
</head>
<body>
    Country:
    <select id="selectCountries" multiple="multiple">
        <option selected="selected" value="USA">United States</option>
        <option value="IND">India</option>
        <option value="UK">United Kingdom</option>
        <option value="CA">Canada</option>
        <option value="AU">Australia</option>
    </select>
    <br /><br />
    <div id="divResult"></div>
</body>
</html>
