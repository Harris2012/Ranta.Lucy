function PreviewController($scope) {

    $scope.init = function () {

        // ajax demo
        $('#ajax')
        .on("changed.jstree", function (e, data) {
            if (data.selected.length) {
                alert('The selected node is: ' + data.instance.get_node(data.selected[0]).text);
            }
        })
        .jstree({
            'core': {
                'data': {
                    "method": "POST",
                    "url": "http://localhost:8529/api/database/tablelist?tableName=aa",
                    "dataType": "json" // needed only if you do not supply JSON headers
                }
            }
        });

        $scope.fieldList = [];

        $scope.updateIndex();

        //Fields
        $('#fields').sortable({ placeholder: 'field-placeholder', stop: $scope.fieldSortStop });
    }

    $scope.newField = function () {
        $scope.fieldList.push({
            fieldIndex: 0,
            setFieldIndex: function (newIndex) {
                this.fieldIndex = newIndex;
            }
        });

        $scope.updateIndex();
    }

    //更新排序字段
    $scope.updateIndex = function () {

        for (var i = 0; i < $scope.fieldList.length; i++) {

            if ($scope.fieldList[i].setFieldIndex == null) {
                $scope.fieldList[i].setFieldIndex = function (newIndex) {
                    this.fieldIndex = newIndex;
                }
            }

            $scope.fieldList[i].setFieldIndex(i + 1);
        }
    }

    $scope.fieldSortStop = function (event, ui) {

        var newFieldList = [];

        $(event.target).children().each(function (index, item) {

            newFieldList.push(angular.element(item).scope().field);
        })


        $scope.$apply(function () {
            $scope.fieldList = newFieldList;

            $scope.updateIndex();
        });
    }
}