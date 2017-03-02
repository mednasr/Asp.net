angular.module('app', ['Evpro.ParticipantCtrl'])
 .directive('loadingButton',function() {
        return{
            restrict: 'A',
            link: function(scope, element, attrs) {
                $(element).ladda();

                $(element).ladda('start');
            }
        };
    });