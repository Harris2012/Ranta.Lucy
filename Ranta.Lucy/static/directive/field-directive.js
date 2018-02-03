function FieldDirective(MetaService) {
    return {
        restrict: 'E',
        templateUrl: '/static/directive/field-view.html',
        replace: true,
        scope: {},
        link: function (scope) {

            //字段列表
            MetaService.fieldTypeGroupList().then(function (response) {
                scope.fieldTypeGroupList = response;
            }, function (response) {
                alert("加载字段列表失败");
            });

            scope.getFieldType = function (fieldTypeName) {
                for (var i = 0; i < scope.fieldTypeGroupList.length; i++) {
                    for (var j = 0; j < scope.fieldTypeGroupList[i].fieldList; j++) {
                        if (scope.fieldTypeGroupList[i].fieldList[j].fieldName == fieldTypeName) {
                            return scope.fieldTypeGroupList[i].fieldList[j];
                        }
                    }
                }
                return null;
            }

            scope.oldField = scope.$parent.field;
            scope.newField = {};
            scope.newField.fieldName = scope.oldField.fieldName;
            scope.newField.fieldType = scope.oldField.fieldType;
            scope.newField.fieldLength = scope.oldField.fieldLength;

            scope.isEditing = true;

            scope.fieldTypeBoxClicked = function (event) {
                scope.isEditingFieldType = !scope.isEditingFieldType;
            }
            window.filedTypeL1MouseEnter = function (item) {
                $(item).find('ul').show();
            }
            window.fieldTypeL1MouseLeave = function (item) {
                $(item).find('ul').hide();
            }
            scope.l2Click = function (event) {

                scope.newField.fieldType = $(event.target).data('type');
                scope.newField.lengthOmissable = $(event.target).data('lengthomissable');

                scope.isEditingFieldType = false;
            }


            scope.openEditField = function () {
                scope.isEditing = true;
            }

            //删除字段
            scope.deleteField = function () {
                scope.$parent.fieldList.splice($.inArray(scope.$parent.field, scope.$parent.fieldList), 1);
            }

            //取消编辑字段
            //新增的字段，点击取消的时候，执行删除
            //原有的字段，点击取消的时候，恢复原来的状态
            scope.cancelEditField = function () {
                scope.isEditing = false;

                if (scope.oldField.fieldName == null) {
                    scope.$parent.fieldList.splice($.inArray(scope.$parent.field, scope.$parent.fieldList), 1);
                }
                else {
                    scope.newField.fieldName = scope.oldField.fieldName;
                }
            }

            //保存字段
            scope.saveField = function () {

                scope.isEditing = false;

                scope.oldField.fieldName = scope.newField.fieldName;
                scope.oldField.fieldType = scope.newField.fieldType;
                scope.oldField.fieldLength = scope.newField.fieldLength;
            }
        }
    }
}
