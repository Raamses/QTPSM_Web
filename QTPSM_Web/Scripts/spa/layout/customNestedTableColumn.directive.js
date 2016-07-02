(function (app) {
    'use strict';

    app.directive('customNestedTableColumn', customNestedTableColumn);

    function customNestedTableColumn() {
        return {
            restrict: 'EA',
            templateUrl: "/Scripts/spa/layout/nestedTableColumn.html",
            scope: {
                columns: '=columnNames'
            }
            //link: function (scope, element, attrs) {
            //    scope.createTableHeaders = function () {
            //        //var columns = eval(attrs.columnNames);
            //        if (scope.columns.length > 0) {
            //            for (var i in scope.columns) {
            //                if (element.context.innerText.toString().indexOf(scope.columns[i]) == -1) {
            //                    element.append("<th class=\"col-xs-1\" style=\"vertical-align:middle\">" + scope.columns[i] + "</th>");
            //                }
            //            }
            //        }
            //    };
            //}
        };
    }

})(angular.module('common.ui'));