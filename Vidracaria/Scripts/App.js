var angular;
(function () {
    var app = angular.module('store', [
        // Angular Modules
        'ngRoute',
        // Custom Modules
        // 3rd Party Modules
        'kendo.directives'
    ]);
    app.controller('PessoaController', function ($scope, $http) {
        $http.get("/Pessoas/Pessoas")
            .then(function (response) {
            $scope.pessoas = response.data;
            /*
            .success(function (result) {
                $scope.pessoas = result;
                alert("yes");
            })
            .error(function (result) {
                console.log(result);
                alert("no");
            */
        });
    });
    app.controller('StoreController', function () {
        this.products = gems;
    });
    /*
    var gems = [
        {
            name: "Dodecahedron",
            price: 2,
            description: "...",
            canPurchase: true,
            soldOut: false
        },
        {
            name: "Pentagonal Gem",
            price: 5.95,
            description: "...",
            canPurchase: true,
            soldOut: false
        }
    ];
    */
    var gems = [
        {
            name: "Dodecahedron",
            price: 2.95,
            description: '...',
            images: [
                {
                    full: "/Content/img/02.png",
                    thumb: "/Content/img/02.png"
                },
                {
                    full: "/Content/img/02.png",
                    thumb: "/Content/img/02.png"
                }
            ]
        },
        {
            name: "Pentagonal Gem",
            price: 5.95,
            description: "...",
            images: [
                {
                    full: "/Content/img/02.png",
                    thumb: "/Content/img/02.png"
                },
                {
                    full: "/Content/img/02.png",
                    thumb: "/Content/img/02.png"
                }
            ]
        }
    ];
})();
