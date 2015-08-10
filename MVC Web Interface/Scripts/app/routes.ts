/// <reference path="../typings/angularjs/angular.d.ts" />
/// <reference path="../typings/angularjs/angular-route.d.ts" />
'use strict';

module School {
    export class Routes {
        static $inject = ['$routeProvider'];
        static configure($routeProvider: ng.route.IRouteProvider) {
            $routeProvider.when('/', { controller: Controllers.StudentsListController, templateUrl: 'Scripts/app/views/list.html' });
        }
    }
}