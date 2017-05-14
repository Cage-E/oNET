/// <reference path="angular.js" />

var myApp = angular
    .module("myModule", [])
    .controller("myController", function ($scope) {
        $scope.message = "Shotor";
    })
    .controller("employeeController", function ($scope) {
        var employee = {
            firstName: "David",
            lastName: "Oghli",
            gender: 'Male'
        };
        $scope.employee = employee;
    })
    .controller("animalPic", function ($scope) {
        var animal = {
            name: 'Turtle',
            image: '/Images/turtle.gif'
        };
        $scope.animal = animal;
    })
    .controller("employeesController", function ($scope) {
        var employees = [
            { firstName: "Ben", lastName: "Hastings", gender: "Male", salary: 55000 },
            { firstName: "Sara", lastName: "Paul", gender: "Female", salary: 68000 },
            { firstName: "Mark", lastName: "Holland", gender: "Male", salary: 57000 },
            { firstName: "Pam", lastName: "Macintosh", gender: "Female", salary: 53000 },
            { firstName: "Todd", lastName: "Barber", gender: "Male", salary: 60000 }
        ];
        $scope.employees = employees;
    })
    .controller("countriesController", function ($scope) {
        var countries = [
            {
                name: "UK",
                cities: [
                    { name: "London" },
                    { name: "Birmingham" },
                    { name: "Manchester" }
                ]
            },
            {
                name: "USA",
                cities: [
                    { name: "Los Angeles" },
                            { name: "Chicago" },
                            { name: "Houston" }
                ]
            },
            {
                name: "India",
                cities: [
                    { name: "Hyderabad" },
                    { name: "Chennai" },
                    { name: "Mumbai" }
                ]
            }
        ];
        $scope.countries = countries;
    })
    .controller("technologiesController", function ($scope) {
        var technologies = [
            { name: "C#", likes: 0, dislikes: 0 },
            { name: "ASP.NET", likes: 0, dislikes: 0 },
            { name: "SQL", likes: 0, dislikes: 0 },
            { name: "AngularJS", likes: 0, dislikes: 0 }
        ];

        $scope.technologies = technologies;

        $scope.incrementLikes = function(technology){
            technology.likes++;
        };

        $scope.incrementDislikes = function (technology) {
            technology.dislikes++;
        };
    })
        .controller("employees10Controller", function ($scope) {
            var employees = [
                {
                    name: "Ben", dateOfBirth: new Date("November 23, 1980"),
                    gender: "Male", salary: 55000
                },
                {
                    name: "Sara", dateOfBirth: new Date("May 05, 1970"),
                    gender: "Female", salary: 68000
                },
                {
                    name: "Mark", dateOfBirth: new Date("August 15, 1974"),
                    gender: "Male", salary: 57000
                },
                {
                    name: "Pam", dateOfBirth: new Date("October 27, 1979"),
                    gender: "Female", salary: 53000
                },
                {
                    name: "Todd", dateOfBirth: new Date("December 30, 1983"),
                    gender: "Male", salary: 60000
                }
            ];

            $scope.employees = employees;
            $scope.sortColumn = 'name';
            $scope.reverse = false;

            $scope.changeSortTo = function (column) {
                $scope.reverse = ($scope.sortColumn == column) ? !$scope.reverseSort : false;
                $scope.sortColumn = column;
            }

            $scope.getArrowClass = function (column) {
                if ($scope.sortColumn == column) {
                    return $scope.reverse ? 'arrow-down' : 'arrow-up';
                }
                return '';
            }

        });






//myApp

////var employeeModule = angular.module("employeeModule", []);

//myApp.controller("employeeController", function ($scope) {
//    var employee = {
//        firstName : "David",
//        lastName: "Oghli",
//        gender : 'Male'
//    };
//    $scope.employee = employee;


