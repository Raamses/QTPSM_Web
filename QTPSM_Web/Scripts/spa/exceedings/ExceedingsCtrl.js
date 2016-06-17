(function (app) {
    'use strict';

    app.controller('exceedingsCtrl', exceedingsCtrl);

    exceedingsCtrl.$inject = ['$scope', '$modal', 'apiService', 'notificationService'];

    function exceedingsCtrl($scope, $modal, apiService, notificationService) {

        $scope.pageClass = 'page-exceedings';
        $scope.loadingExceedings = true;
        $scope.services = [];
        $scope.page = 0;
        $scope.pagesCount = 0;
        //$scope.loadServices = loadServices;

        $scope.search = search;
        $scope.clearSearch = clearSearch;

        $scope.search = search;
        $scope.clearSearch = clearSearch;
        //$scope.openEditDialog = openEditDialog;

        //function loadServices() {
        //    $scope.loadingExceedings = true;

        //    apiService.get('/api/services/active', null,
        //    servicesLoadCompleted,
        //    servicesLoadFailed);
        //}

        function search(page) {
            page = page || 0;

            $scope.loadingExceedings = true;

            var config = {
                params: {
                    page: page,
                    pageSize: 10,
                    filter: $scope.filterServices
                }
            };

            apiService.get('/api/services/active', config,
             servicesLoadCompleted,
             servicesLoadFailed);
        }

        //function openEditDialog(customer) {
        //    $scope.EditedCustomer = customer;
        //    $modal.open({
        //        templateUrl: 'scripts/spa/customers/editCustomerModal.html',
        //        controller: 'customerEditCtrl',
        //        scope: $scope
        //    }).result.then(function ($scope) {
        //        clearSearch();
        //    }, function () {
        //    });
        //}

        function servicesLoadCompleted(result) {

            $scope.services = result.data.items;

            $scope.page = result.data.page;
            $scope.pagesCount = result.data.totalPages;
            $scope.totalCount = result.data.totalCount;
            $scope.loadingExceedings = false;

            //notificationService.displayInfo(result.data.Items.length + ' servicess found');
        }

        function servicesLoadFailed(response) {
            notificationService.displayError(response.data);
        }

        function clearSearch() {
            $scope.filterCustomers = '';
            search();
        }

        $scope.search();
    }

})(angular.module('QTPSM'));