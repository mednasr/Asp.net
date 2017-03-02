angular.module("Evpro.ParticipantCtrl", [])
    .controller("ParticipantCtrl",
    [
        "$scope", "$http", function($scope, $http) {
            $scope.model = {};
            $scope.states = {
                showParticipantForm: false
            };
            $scope.new = {
                Participant: {}
            };

            $http.get("/Participant/IndexParticipantVM")
                .success(function(data) {
                    $scope.model = data;
                });

            $scope.showParticipantForm = function(show) {
                $scope.states.showParticipantForm = show;
            };

            $scope.addParticipant = function () {
                //console.log($scope.new.Participant);
                $http.post("/Participant/Create",$scope.new.Participant).success(function (data) {

                    $scope.model.push(data);
                    $scope.showParticipantForm(false);
                    $scope.new.Participant = {};

                });
            };
            $scope.rowLimit = 5;
            $scope.sortColumn = "FirstName";
            $scope.reverseSort = false;
            $scope.sortData = function (column) {
                $scope.reverseSort = ($scope.sortColumn == column) ? !$scope.reverseSort : false;  // yaani if ($scope.sortColumn == column)  ?= then  !$scope.reverseSort =  reverseSort ta5ou 3aksha yaani kanit false twali true     : = else
                $scope.sortColumn = column;
            }
            $scope.getSortClass = function (column) {
                if ($scope.sortColumn == column) {
                    return $scope.reverseSort ? 'arrow-down' : 'arrow-up'
                }
                return '';
            }
        }
    ]);