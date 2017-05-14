<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm_07.aspx.cs" Inherits="AngularWebApplication.WebForm_07" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="Scripts/angular.js"></script>
    <script src="Scripts/myJS.js"></script>
    <link href="StyleSheet.css" rel="stylesheet" />
    <title></title>
</head>
<body data-ng-app="myModule">
    <div data-ng-controller="technologiesController">
    <table>
        <thead>
            <tr>
                <th>Name</th>
                <th>Likes</th>
                <th>Dislikes</th>
                <th>Like/Dislike</th>
            </tr>
        </thead>
        <tbody>
            <tr data-ng-repeat="technology in technologies">
                <td>{{technology.name}}</td>
                <td>{{technology.likes}}</td>
                <td>{{technology.dislikes}}</td>
                <td>
                    <input type="button" value="Like" data-ng-click="incrementLikes(technology)" />
                    <input type="button" value="Dislike" data-ng-click="incrementDislikes(technology)" />
                </td>
            </tr>
        </tbody>
    </table>
    </div>
</body>
</html>
