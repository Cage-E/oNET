<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm_01.aspx.cs" Inherits="AngularWebApplication.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" data-ng-app="myModule">
<head>
    <title></title>
    <script src="Scripts/angular.js"></script>
    <script src="Scripts/myJS.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div data-ng-controller="myController">
        <input type="text" data-ng-model="message"/>
        {{message}}
    </div>
    <div data-ng-controller="employeeController">
        <div>
            Fist name = {{ employee.firstName }} <br />
        Last name = {{ employee.lastName }} <br />
        Gender = {{ employee.gender }}
        </div>
        <div>
            <table style="border:2px;">
                <tr>
                    <td>
                        First name
                    </td>
                    <td>
                        <input type="text" data-ng-model="employee.firstName"/>
                    </td>
                </tr>
                <tr>
                    <td>
                        Last name
                    </td>
                    <td>
                        <input type="text" data-ng-model="employee.lastName"/>
                    </td>
                </tr>
                <tr>
                    <td>
                        Gender
                    </td>
                    <td>
                        <input type="text" data-ng-model="employee.gender"/>
                    </td>
                </tr>
            </table>
        </div>
        <div>
            <table style="border:2px;">
                <tr>
                    <td>
                        First name
                    </td>
                    <td>
                        {{ employee.firstName }}
                    </td>
                </tr>
                <tr>
                    <td>
                        Last name
                    </td>
                    <td>
                        {{ employee.lastName }}
                    </td>
                </tr>
                <tr>
                    <td>
                        Gender
                    </td>
                    <td>
                        {{ employee.gender }}
                    </td>
                </tr>
            </table>
        </div>
    </div>
    <div data-ng-controller="animalPic">
        Animal name: {{ animal.name }} <br />
        <image ng-src="{{ animal.image}}" alt="Turtle image"></image>
    </div>
    </form>
</body>
</html>
