(function (win) {
    var lucy = {};

    var schemaIndex = 1, tableIndex = 1, fieldIndex = 1;

    lucy.getSafeSchemaName = function () {
        return "Schema_" + schemaIndex++;
    }
    lucy.getSafeTableName = function () {
        return "Table_" + tableIndex++;
    }
    lucy.getSafeFieldName = function () {
        return "Field_" + fieldIndex++;
    }

    lucy.areaSortStop = function (event, ui) {
        if ($(ui.item).data('name') == undefined) {
            var name = lucy.getSafeSchemaName();
            $(ui.item).data('name', name);
            $(ui.item).find('.panel-heading span').text(name);
        }
        $(ui.item).removeAttr('style');
        $(ui.item).find('.panel-body').sortable({
            placeholder: 'table-placeholder',
            connectWith: '#area .panel-info > .panel-body',
            stop: lucy.schemaSortStop
        });
    }

    lucy.schemaSortStop = function (event, ui) {
        if ($(ui.item).data('name') == undefined) {
            var name = lucy.getSafeTableName();
            $(ui.item).data('name', name);
            $(ui.item).find('.panel-heading span').text(name);
        }
        $(ui.item).removeAttr('style');
        $(ui.item).find('.panel-body').sortable({
            connectWith: '#area .panel-info > .panel-body',
            placeholder: 'field-placeholder',
            stop: lucy.tableSortStop
        });
    }
    lucy.tableSortStop = function (event, ui) {
        if ($(ui.item).data('name') == undefined) {
            var name = lucy.getSafeFieldName();
            $(ui.item).data('name', name);
            $(ui.item).find('.panel-heading span').text(name);
        }
        $(ui.item).removeAttr('style');
    }

    lucy.canSubmit = function () {
        var isValid = validateData();
        if (isValid) {
            var jsonData = lucy.generateJsonData();

            var textData = JSON.stringify(jsonData);

            $('#Data').val(textData);

            return true;
        } else {
            return false;
        }
    }
    function validateData() {
        var isValid = true;
        if ($('#area .panel-info').length == 0) {
            $('#area').addClass('error');
            isValid = false;
        } else {
            $('#area').removeClass('error');
            //Check schema one by one.
            $('#area .panel-info').each(function (index, element) {
                var name = $(element).data('name');
                //Name of the schema should not be undefined.
                if (name == undefined) { $(element).addClass('error'); isValid = false; } else { $(element).removeClass('error'); }
                //There should be at least one table in schema.
                if ($(element).find('.panel-success').length == 0) {
                    $(element).find('.panel-body').addClass('error');
                    isValid = false;
                } else {
                    $(element).find('.panel-body').removeClass('error');
                    //Check table one by one.
                    $(element).find('.panel-success').each(function (index, element) {
                        var name = $(element).data('name');
                        //Name of the table should not be undefined.
                        if (name == undefined) { $(element).addClass('error'); isValid = false; } else { $(element).removeClass('error'); }
                        //There should be at least one field in table.
                        if ($(element).find('.panel-warning').length == 0) {
                            $(element).find('.panel-body').addClass('error');
                            isValid = false;
                        } else {
                            $(element).find('.panel-body').removeClass('error');
                            //Check field one by one.
                            $(element).find('.panel-warning').each(function (index, element) {
                                var name = $(element).data('name');
                                if (name == undefined) {
                                    $(element).addClass('error');
                                    isValid = false;
                                } else {
                                    $(element).removeClass('error');
                                }
                            });
                        }
                    });
                }
            });
        }

        return isValid;
    }

    lucy.generateJsonData = function () {
        var schemas = {};
        $('#area .panel-info').each(function (index, element) {
            var schema = {};
            var schemaName = $(element).data('name');
            schema.Name = schemaName;
            schema.Tables = {};
            $(element).find('.panel-success').each(function (index, element) {
                var table = {};
                var tableName = $(element).data('name');
                table.Name = tableName;
                table.SchemaName = schemaName;
                table.Fields = {};
                $(element).find('.panel-warning').each(function (index, element) {
                    var field = {};
                    var fieldName = $(element).data('name');
                    field.Name = fieldName;

                    table.Fields[fieldName] = field;
                });
                schema.Tables[tableName] = table;
            });
            schemas[schemaName] = schema;
        });

        console.log(schemas);

        return schemas;
    }

    win.lucy = lucy;
})(window);

$(function () {
    //IDE Setting Begin
    $('#ide').sortable({
        placeholder: 'ide-item-placeholder'
    });
    //IDE Setting End

    $('#area').delegate('.glyphicon-plus', 'click', function () {
        $(this).parent().parent().next().height($(this).parent().parent().next().height() + 10);
    });
    $('#area').delegate('.glyphicon-minus', 'click', function () {
        $(this).parent().parent().next().height($(this).parent().parent().next().height() - 10);
    });
    $('#area').delegate('.glyphicon-arrow-up', 'click', function () {
        $(this).parent().parent().next().slideUp(100);
        $(this).hide();
        $(this).next().show();
    });
    $('#area').delegate('.glyphicon-arrow-down', 'click', function () {
        $(this).parent().parent().next().slideDown(100);
        $(this).hide();
        $(this).prev().show();
    });
    $('#area').delegate('.glyphicon-remove', 'click', function () {
        //TODO add dialog here
        $(this).parent().parent().parent().fadeOut(100);
        $(this).parent().parent().parent().remove();
    });

    $('#area').delegate('.panel-heading > span', 'click', function () {
        $('#property').show();
        $('#property').find('.panel').hide();
        switch ($(this).parent().parent().data('type')) {
            case "schema":
                $('#property').find('.panel-info').show();
                break;
            case "table":
                $('#property').find('.panel-success').show();
                break;
            case "field":
                $('#property').find('.panel-warning').show();
                break;
            default:
                break;
        }
    });

    $('#area').sortable({
        placeholder: 'schema-placeholder',
        stop: lucy.areaSortStop
    });
    $('#area .panel-info>.panel-body').sortable({
        connectWith: '#area .panel-info > .panel-body',
        placeholder: 'table-placeholder',
        stop: lucy.schemaSortStop
    });
    $('#area .panel-success>.panel-body').sortable({
        connectWith: '#area .panel-success > .panel-body',
        placeholder: 'field-placeholder',
        stop: lucy.tableSortStop
    });

    // Set toobox item to draggable
    $('#toolbox .panel-info').draggable({
        helper: 'clone',
        connectToSortable: '#area'
    });
    $('#toolbox .panel-success').draggable({
        helper: 'clone',
        connectToSortable: '#area .panel-info > .panel-body'
    });
    $('#toolbox .panel-warning').draggable({
        helper: 'clone',
        connectToSortable: '#area .panel-success > .panel-body'
    });
})