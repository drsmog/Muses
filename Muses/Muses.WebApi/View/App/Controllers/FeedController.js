musesApp.controller('feedController', ['$scope', 'feedFactory', function ($scope, feedFactory) {

    $scope.searchFeeds = function (searchString) {

        feedFactory.getFeeds(searchString).then(
            function (result) {
                $scope.feedCollection = result.data;
            },
            function (result) {
                $scope.feedCollection = [];
                alert("its sucks");
            });

        $scope.feedCollection = [
            { title: 'title1', description: '<b>this is bold content1</b>' },
            { title: 'title2', description: '<b>this is bold content2</b>' }
        ];

    }

    $scope.initFeed = function () {

        $scope.searchFeeds('*');

    }

    $scope.initFeed();

    

    $scope.searchStringChangedEvent= function() {
        $scope.searchFeeds($scope.searchString);
    }


}]);