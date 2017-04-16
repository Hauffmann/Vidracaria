var angular;
(function () {
    var app = angular.module('store', [
        // Custom Modules
        'brasil.filters',
        // 3rd Party Modules
        'kendo.directives'
    ]);
    /*
    app.controller("kendoPessoas", function ($scope) {
        $scope.mainGridOptions = {
            
            dataSource = new kendo.data.DataSource({
                transport: {
                    read: {
                        url: "/Pessoas/Pessoas",
                        dataType: "json"
                    },
                    update: {
                        url: "/Pessoas/Pessoas",
                        dataType: "json"
                    },
                    destroy: {
                        url: "/Pessoas/Pessoas",
                        dataType: "json"
                    },
                    create: {
                        url: "/Pessoas/Pessoas",
                        dataType: "json"
                    },
                    parameterMap: function (option, operation) {
                        if (operation !== "read" && options.models) {
                            return { models: kendo.stringfy(options.models) };
                        }
                    }
                },
                batch: true,
                pageSize: 10,
                schema: {
                    model: {
                        id: "Id",
                        fields: {
                            Nome: { editable: true, nullable: true },
                            Sobrenome: { validation: { required: false } }
                        }
                    }
                }
            }),
            dataSource: dataSource,
            filterable: { mode: "row" },
            groupable: true,
            sortable: true,
            pageable: {
                refresh: true,
                pageSizes: true,
                buttonCount: 5
            },
            height: 610,
            toolbar: ["create"],
            columns: [
                { field: "Nome", title: "Nome" },
                { field: "Sobrenome", title: "Sobrenome" },
                { field: "Cpf", title: "Cpf" },
                { command: ["edit", "destroy"], title: "&nbsp;", width: "250px" }],
            editable: "popup"
        }
    });
    */
    app.controller("MyCtrl", function ($scope) {
        $scope.mainGridOptions = {
            dataSource: {
                type: "odata",
                transport: {
                    read: "//demos.telerik.com/kendo-ui/service/Northwind.svc/Employees"
                }
            },
            columns: [{
                    field: "FirstName",
                    title: "First Name {{1+1}}",
                    headerAttributes: { "ng-non-bindable": true },
                    width: "180px"
                }, {
                    field: "LastName",
                    title: "Last Name",
                    width: "120px"
                }, {
                    field: "Country",
                    width: "120px"
                }, {
                    field: "City",
                    width: "120px"
                }]
        };
    });
    app.controller("MyCtrl2", function ($scope) {
        $scope.mainGridOptions = {
            dataSource: {
                type: "json",
                transport: {
                    read: "/Pessoas/Pessoas"
                },
                pageSize: 10
            },
            columns: [{
                    field: "p.Nome",
                    width: "120px"
                }, {
                    field: "p.Sobrenome",
                    width: "120px"
                }, {
                    field: "p.Cpf",
                    width: "120px"
                }]
        };
        $scope.detailGridOptions = {
            dataSource: {
                type: "json",
                transport: {
                    read: "/Pessoas/Pessoas"
                },
                pageSize: 10
            },
            columns: [{
                    field: "p.Pedidos.DataEntrega",
                    width: "120px"
                }, {
                    field: "p.Pedidos.Valor",
                    width: "120px"
                }]
        };
    });
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
//# sourceMappingURL=app.js.map