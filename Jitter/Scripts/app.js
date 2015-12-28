<<<<<<< HEAD
﻿var app = angular.module("jitter", []);
app.controller("TestController", [ "$scope", "$http", function ($scope, $http) {
    $scope.test = "test variable";
    $scope.hello = function(){
        //$scope.test = "Hello World";

        $http.get("/api/Test")
            .success(function (data) {
                $scope.test = data;
            })
            .error(function () {
                alert(error.error)
            })
=======
﻿var app = angular.module('jitter', []);

app.controller('Controller', ["$scope", "$http", function ($scope, $http) {
    $scope.test = "test variable";

    $scope.deleteUsers = function () {
        $http.delete("/api/Test")
            .success(function (data) {
                alert("Deleting Users Yay!");
            })
            .error(function (error) { alert(error.error) });
    }

    $scope.hello = function () {
        $http.get("/api/Test")
            .success(function (data) {
                $scope.test = data;})
            .error(function (error) { alert(error.error) });
>>>>>>> 4edeb1fa679168e0ca6b2a99e69dbb6b4b1e00b7
    }
}]);