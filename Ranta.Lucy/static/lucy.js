var preview_module = angular.module('preview', ['ngResource']);

// Service
preview_module.service('MetaService', ['$resource', '$q', MetaService]);

// Directive
preview_module.directive('field', FieldDirective);

// Controller
preview_module.controller('preview_controller', ['$scope', PreviewController]);