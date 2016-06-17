(function (app) {
    'use strict';

    app.controller('indexCtrl', indexCtrl);

    indexCtrl.$inject = ['$scope', 'apiService', 'notificationService'];

    function indexCtrl($scope, apiService, notificationService) {
        $scope.pageClass = 'page-home';
        $scope.loadingData = true;
        $scope.isReadOnly = true;

        $scope.engineerEffortPerFP = [];
        $scope.loadData = loadData;
        $scope.currentFP = '';

        function loadData() {
            //apiService.get('/api/finance_period/current', null,
            //            getCurrentFPCompleted,
            //            getCurrentFPfailed);

            apiService.get('/api/effort_per_engineer_and_fp/all', null,
                        engineerLoadCompleted,
                        engineerLoadFailed);
        }

        function engineerLoadCompleted(result) {
            $scope.engineerEffortPerFP = result.data;
            $scope.currentFP = result.data[0].finance_period_name;
            $scope.loadingData = false;
        }

        function engineerLoadFailed(response) {
            notificationService.displayError(response.data);
        }

        function getCurrentFPCompleted(result) {
            $scope.currentFP = result.data;
        }

        function getCurrentFPfailed(result) {
            $scope.currentFP = result.data;
        }

        loadData();
    }

})(angular.module('QTPSM'));