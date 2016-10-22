/**
 * Created by Administrator on 2015/8/20.
 */
app.register.controller("newsList", function($scope, $http) {

    $scope.title = "list";

    $http.get('/ZDL/AngularJs/News/Ajax/NewsAJax.ajax/GetList')
        .success(function(data, status, headers, config) {
            $scope.mainList = data;
        }).error(function(data, status, headers, config) {
            alert('错误');
        });

    $scope.add = function(e) {
        var newObj = { 'id': '5', 'title': '水下推开每个门搜幸存者' };
        this.mainList.list.splice(0, 0, newObj);
    }

    $scope.edit = function(info) {
        info.title = "谎称71年生得怪病显得年轻";
    }

    $scope.del = function(index) {
        this.mainList.splice(index, 1);
    }
})
