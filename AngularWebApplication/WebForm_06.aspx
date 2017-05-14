<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm_06.aspx.cs" Inherits="AngularWebApplication.WebForm_06" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="Scripts/angular.js"></script>
    <script src="Scripts/myJS.js"></script>
    <title></title>
</head>
<body data-ng-app="myModule">
    <div data-ng-controller="countriesController">
        <ul>
            <li data-ng-repeat="country in countries">
                {{ country.name }}, Index = {{ $index }}
                <ul>
                    <li data-ng-repeat="city in country.cities">
                        {{ city.name }}, parent Index = {{ $parent.$index }}, Index = {{ $index }}
                    </li>
                </ul>
            </li>
        </ul>
    </div>
    <div data-ng-controller="employeesController">
        <table>
            <thead>
            <tr>
                <th>Firstname</th>
                <th>Lastname</th>
                <th>Gender</th>
                <th>Salary</th>
            </tr>
            </thead>
            <tbody>
                <tr data-ng-repeat="employee in employees">
                    
                    <td> {{ employee.firstName }} </td>
                    <td> {{ employee.lastName }} </td>
                    <td> {{ employee.gender }} </td>
                    <td> {{ employee.salary }} </td>
                </tr>
            </tbody>
        </table>
    </div>
</body>
</html>
