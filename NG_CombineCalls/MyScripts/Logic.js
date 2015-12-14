/// <reference path="E:\Mahesh_New\Articles\Dec2015\NG_Combine_Multiple_Promises\NG_CombineCalls\Scripts/angular.min.js" />
//1.
var app = angular.module('mymodule', []);
//2.
app.service('courseService', function ($http) {
    this.get = function () {
        var response = $http.get("http://localhost:42490/Courses");
        return response;
    };
});
//3.
app.service('studentService', function ($http) {
    this.get = function () {
        var response = $http.get("http://localhost:42490/Students");
        return response;
    };
});

//4.
app.controller('ctrl', function ($scope, $q, courseService, studentService) {

    $scope.Courses = [];
    $scope.Students = [];
    loadData();

    //5.
    function loadData() {
        var promiseCourse = courseService.get();
        var promiseStudent = studentService.get();

        $scope.combineResult = $q.all([
            promiseCourse, 
            promiseStudent 
        ]).then(function (resp) {
           $scope.Courses= resp[0].data;
           $scope.Students= resp[1].data;
        });
    }
});