/// <reference path="../angular/angular.min.js" />
var app = angular.module('WebAuctionApp', ['ngRoute']);

app.config(function ($routeProvider) {
    $routeProvider.when('/', {
        controller: 'LoginController',
        templateUrl: 'Views/Login.html'
    });
});