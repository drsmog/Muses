musesApp.factory('feedFactory', function($http) {
    var factory = {};

    factory.getFeeds = function(searchString) {
        return $http.get('../api/feed', {
            params: {searchString:searchString}
        });
    }

    return factory;
})