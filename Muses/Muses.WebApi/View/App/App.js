var musesApp = angular.module('musesApp', ['ngRoute', 'ngSanitize']);

musesApp.config(function($routeProvider) {

    $routeProvider
        .when('/',
        {
            controller: 'feedController',
            templateUrl: 'App/Template/FeedTemplate.html'
        });

});

