(function () {
    'use strict';

    var magazineApp = angular.module('magazineApp', []);

    magazineApp.controller("MagazineController", function ($scope, $http) {

        $http.get('http://localhost:52826/api/Stores')
            .then(function (response) {
                $scope.stores = response.data;
            });
    });


    //magazineApp.controller("MagazineController", function ($scope) {
    //    $scope.records = [
    //       {
    //           "Name": "Alfreds Futterkiste",
    //           "Country": "Germany"
    //       }, {
    //           "Name": "Berglunds snabbköp",
    //           "Country": "Sweden"
    //       }, {
    //           "Name": "Centro comercial Moctezuma",
    //           "Country": "Mexico"
    //       }, {
    //           "Name": "Ernst Handel",
    //           "Country": "Austria"
    //       }
    //    ]
    //});

    //    function ($scope, $http) {

    //    $http.get('http://localhost:52826/api/Stores')
    //        .then(function (response) {
    //            $scope.stores = response.data;
    //        });
    //});


    //    .controller('MagazineController', function ($scope) {
    //        $scope.stores = [{
    //            name: "first name",
    //            address: "qqqqqqqqqqqq",
    //            startWorkTime: "32.32",
    //            endWorkTime: "32.32"

    //        }, {
    //            name: "last name",
    //            address: "wwwwwwwwwwwwww",
    //            startWorkTime: "23.23",
    //            endWorkTime: "23.23"
    //        }]

    //});



    //var MagazineController = function ($scope, $http) {

    //    var getStores = function () {
    //        $http.get('http://localhost:52826/api/Stores')
    //            .success(function (data) {
    //                $scope.Stores = data.Stores;
    //        });
    //    };

    //    getStores();
    //};



    //magazineApp.controller("MagazineController", ["$scope", "$http", MagazineController]);

    //MagazineController.$inject = ['$scope']; 

    //function MagazineController($scope) {
    //    /* jshint validthis:true */
    //    var vm = this;
    //    vm.title = 'MagazineController';

    //    activate();

    //    function activate() { }
    //}
}());
