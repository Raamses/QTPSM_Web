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
        $scope.getExceedingBGColor = getExceedingBGColor;
        $scope.columnNames = [];


        $scope.search = search;
        $scope.clearSearch = clearSearch;

        $scope.search = search;
        $scope.clearSearch = clearSearch;
        //$scope.openEditDialog = openEditDialog;
        var colorMap = {
            exceeded: "tableExceededRow",
            fivePercent: "tableFivePercentRow",
            tenPercent: "tableTenPercentRow"
        }


        Number.prototype.between = function (a, b) {
            var min = Math.min.apply(Math, [a, b]),
              max = Math.max.apply(Math, [a, b]);
            return this > min && this < max;
        };

        function getExceedingBGColor(service) {
            var mod = (service.current_effort / service.current_scope) * 100;
            if (service.current_scope <= service.current_effort) {
                return colorMap.exceeded;
            }
            else if (mod.between(70, 100)) {
                return colorMap.fivePercent;
            }
            else {
                return '';
            }
        }

        function search(page) {
            page = page || 0;

            $scope.loadingExceedings = true;

            var config = {
                params: {
                    page: page,
                    pageSize: 15,
                    filter: $scope.filterServices
                }
            };

            apiService.get('/api/services/active', config,
             servicesLoadCompleted,
             servicesLoadFailed);
        }

        function servicesLoadCompleted(result) {

            $scope.services = result.data.items;
            $scope.columnNames = ["Service Name", "Current Scope", "Current Effort", "Exceeding", "Billable", "Active"];

            $scope.page = result.data.page;
            $scope.pagesCount = result.data.totalPages;
            $scope.totalCount = result.data.totalCount;
            $scope.loadingExceedings = false;

            notificationService.displayInfo(result.data.items.length + ' services found of total ' + $scope.totalCount);
        }

        function servicesLoadFailed(response) {
            notificationService.displayError(response.data);
        }

        function clearSearch() {
            $scope.filterServices = '';
            search();
        }

        $scope.search();
    }

})(angular.module('QTPSM'));