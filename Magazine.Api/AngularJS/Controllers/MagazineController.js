(function () {
    'use strict';

    var magazineApp = angular.module('magazineApp', []);

    magazineApp.controller("MagazineController", function ($scope, $http) {

        $http.get('http://localhost:52826/api/Stores')
            .then(function (response) {
                $scope.stores = response.data;
            });


        $scope.items = function (id) {

            $http({ method: 'GET', url: '/api/Items/' + id }).
             then(function (response) {

                 $scope.item = response.data;
                 $scope.IsItemsList = true;
             })
        };
    });
}());
