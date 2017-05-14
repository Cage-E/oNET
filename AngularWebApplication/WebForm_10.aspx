<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm_10.aspx.cs" Inherits="AngularWebApplication.WebForm_10" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="Scripts/angular.js"></script>
    <script src="Scripts/myJS.js"></script>
    <link href="StyleSheet.css" rel="stylesheet" />
    <title></title>
</head>
<body data-ng-app="myModule">
    <div data-ng-controller="employees10Controller">
        <table>
            <thead>
                <tr>
                    <th data-ng-click="changeSortTo('name')">Name
                        <div data-ng-class="getArrowClass('name')"></div>
                    </th>
                    <th data-ng-click="changeSortTo('dateOfBirth')">Birthdate
                        <div data-ng-class="getArrowClass('dateOfBirth')"></div>
                    </th>
                    <th data-ng-click="changeSortTo('gender')">Gender
                        <div data-ng-class="getArrowClass('gender')"></div>
                    </th>
                    <th data-ng-click="changeSortTo('salary')">Salary
                        <div data-ng-class="getArrowClass('salary')"></div>
                    </th>
                </tr>
            </thead>
            <tbody>
                <tr data-ng-repeat="employee in employees | orderBy: sortColumn : reverse">
                    <td>{{ employee.name }}</td>
                    <td>{{ employee.dateOfBirth | date: yyyy-MM-dd }}</td>
                    <td>{{ employee.gender | lowercase }}</td>
                    <td>{{ employee.salary | number }}</td>
                </tr>
            </tbody>
        </table>

    </div>
</body>
</html>
