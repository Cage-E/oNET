<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="12_WebForm.aspx.cs" Inherits="jQueryWebForms._12_WebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="Scripts/jquery-3.1.1.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $('input[name="skills"]').click(function () {
                getSelectedCheckBoxes('skills');
            });
            $('input[name="cities"]').click(function () {
                getSelectedCheckBoxes('cities');
            });

            var getSelectedCheckBoxes = function (groupName) {
                var result = $('input[name="' + groupName + '"]:checked');
                if (result.length > 0) {
                    var resultString = result.length + " checkbox(es) checked.<br />";
                    result.each(function () {
                        resultString += $(this).val() + "<br />";
                    });
                    $('#div' + groupName).html(resultString);
                }
                else {
                    $('#div' + groupName).html('No checkbox selected!')
                }
            };
        });
    </script>
    <title></title>
</head>
<body>
    Skills:
    <input type="checkbox" name="skills" value="js" />
    <label for="option-js">JavaScript</label>
    <input type="checkbox" name="skills" value="jq" />
         <label for="option-jq">jQuery</label>
    <input type="checkbox" name="skills" value="cs" />
         <label for="option-cs">C#</label>
    <input type="checkbox" name="skills" value="vb" />
         <label for="option-vb">VB</label>
    <br />
    <br />
    Preferred Cities
    <input type="checkbox" name="cities" value="ny" />
         <label for="option-ny">New York</label>
    <input type="checkbox" name="cities" value="nd" />
         <label for="option-nd">New Delhi</label>
    <input type="checkbox" name="cities" value="ln" />
         <label for="option-ln">London</label>
    <br />
    <br />
    Selcted skills:<br />
    <div id="divskills">
    </div>
    <br />
    Selected cities:<br />
    <div id="divcities">
    </div>

</body>
</html>

<!-- 02
    <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="12_WebForm.aspx.cs" Inherits="jQueryWebForms._12_WebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="Scripts/jquery-3.1.1.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $('#btnGetSelectedSkills').click(function () {
            getSelectedCheckBoxes('skills');
        });
        $('#btnGetSelectedCities').click(function () {
            getSelectedCheckBoxes('cities');
        });

        var getSelectedCheckBoxes = function(groupName){
            var result = $('input[name="'+groupName+'"]:checked');
            if (result.length>0) {
                var resultString = result.length + " checkbox(es) checked.<br />";
                result.each(function () {
                    resultString += $(this).val() + "<br />";
                });
                $('#div'+groupName).html(resultString);
            }
            else {
                $('#div'+groupName).html('No checkbox selected!')
            }
        };
        });
    </script>
    <title></title>
</head>
<body>
    Skills:
    <input type="checkbox" name="skills" value="JavaScript" />JavaScript
    <input type="checkbox" name="skills" value="jQuery" />jQuery
    <input type="checkbox" name="skills" value="C#" />C#
    <input type="checkbox" name="skills" value="VB" />VB
    <br />
    <br />
    Preferred Cities
    <input type="checkbox" name="cities" value="New York" />New York
    <input type="checkbox" name="cities" value="New Delhi" />New Delhi
    <input type="checkbox" name="cities" value="London" />London
    <br /><br />
    <input type="submit" id="btnGetSelectedSkills" value="Get selected skills" />
    <input type="submit" id="btnGetSelectedCities" value="Get selected cities" />
    <br /><br />
    Selcted skills:<br />
    <div id="divskills">
    </div>
    <br />
    Selected cities:<br />
    <div id="divcities">
    </div>

</body>
</html>

    -->