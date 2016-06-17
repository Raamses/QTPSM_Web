(function (app) {
    'use strict';

    app.controller('exceedingsCtrl', exceedingsCtrl);

    exceedingsCtrl.$inject = ['$scope', '$modal', 'apiService', 'notificationService'];

    function exceedingsCtrl($scope, $modal, apiService, notificationService) {

        $scope.pageClass = 'page-exceedings';
        $scope.loadingExceedings = true;
        $scope.services = [];
        $scope.loadServices = loadServices;

        $scope.openEditDialog = openEditDialog;

        function loadServices() {
            $scope.loadingExceedings = true;

            apiService.get('/api/services/active', null,
            servicesLoadCompleted,
            servicesLoadFailed);
        }

        function openEditDialog(customer) {
            $scope.EditedCustomer = customer;
            $modal.open({
                templateUrl: 'scripts/spa/customers/editCustomerModal.html',
                controller: 'customerEditCtrl',
                scope: $scope
            }).result.then(function ($scope) {
                clearSearch();
            }, function () {
            });
        }

        function servicesLoadCompleted(result) {
            $scope.services = result.data;
            $scope.loadingExceedings = false;
            //notificationService.displayInfo(result.data.Items.length + ' servicess found');
        }

        function servicesLoadFailed(response) {
            notificationService.displayError(response.data);
        }

        $scope.loadServices();
    }

})(angular.module('QTPSM'));