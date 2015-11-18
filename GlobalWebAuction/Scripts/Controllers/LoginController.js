app.controller('LoginController', ['$scope', '$http', function ($scope, $http) {
    $scope.register = function () {
        $http.post('api/Account/Register', {
            "name": "Roman",
            "surname": "Hapatyn",
            "password": "Mynameiscat1Ok-"
        });
    };
}]);