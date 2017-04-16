angular.module("KendoDemos2", ["kendo.directives", "brasil.filters"])
        .controller("MyCtrl2", function ($scope) {
            $scope.mainGridOptions = {
                dataSource: new kendo.data.DataSource({
                    transport: {
                        read: {
                            url: "/Pessoas/Pessoas",
                            dataType: "json"
                        },
                        create: {
                            url: "/Pessoas/KendoCreate",
                            dataType: "json",
                            type: "POST",
                            contentType: "application/json; charset=utf-8"
                        },
                        update: {
                            url: "/Pessoas/KendoUpdate",
                            dataType: "json",
                            type: "POST",
                            contentType: "application/json; charset=utf-8"
                        },
                        destroy: {
                            url: "/Pessoas/KendoDelete",
                            dataType: "json",
                            type: "POST",
                            contentType: "application/json; charset=utf-8"
                        },
                        parameterMap: function (options, operation) {
                            if (operation !== "read") {
                                console.log(options)
                                return kendo.stringify(options);
                            }
                        }
                    },
                    batch: false,
                    pageSize: 10,
                    schema: {
                        model: {
                            id: "Id",
                            fields: {
                                //Id: { type: "number", editable: false, nulllable: true },
                                Nome: { type: "string", validation: { required: { message: "Campo nome é obrigatório" } } },
                                Sobrenome: { type: "string" },
                                Cpf: { type: "string" },
                                Descricao: { type: "string" },
                                Tipo: { type: "number" },
                                NomeInteiro: { type: "string"}
                            }
                        }
                    },
                    change: function (e) {
                        //console.log("CHANGE HERE");
                    }

                }),
                filterable: {
                    mode: "row",
                    extra: false,
                    messages: {
                        clear: "Limpar"
                    },
                    operators: {
                        string: {
                            contains: "Contém",
                            doesnotcontain: "Não contém",
                            eq: "Igual",
                            neq: "Não igual",
                            startswith: "Começa com",
                            endswith: "Termina com"
                        }
                    }
                },
                groupable: {
                    messages: {
                        empty: "Arraste aqui a coluna que quer agrupar."
                    }
                },
                sortable: { mode: "multiple", allowUnsort: true },
                reorderable: true,
                autoBind: true,
                customBinding: true,
                scrollable: true,
                resizable: true,
                pageable: {
                    refresh: true,
                    pageSizes: [5, 10, 15, 20, 25, 50],
                    buttonCount: 5,
                    messages: {
                        display: "{0} - {1} de {2} items",
                        empty: "Nenhum item para mostrar",
                        page: "Página",
                        allPages: "Todos",
                        of: "de {0}",
                        itemsPerPage: "items por página",
                        first: "Ir para primeira página",
                        previous: "Ir para página anterior",
                        next: "Ir para próxima página",
                        last: "Ir para última página",
                        refresh: "Atualizar"
                    }
                },
                toolbar: [{ name: "create", text: 'Adicionar Novo' }],
                columns: [
                    //{ field: "Id", title: "ID", width: "40px", filterable: false },
                    { field: "Nome", title: "Nome", template: "{{dataItem.Nome}}" },
                    { field: "Sobrenome", title: "Sobrenome" },
                    { field: "Cpf", title: "Cpf", template: "{{ dataItem.Cpf | cpf }}" },
                    { field: "Descricao", title: "Descrição" },
                    { field: "Tipo", Title: "Tipo" },
                    { field: "NomeInteiro", Title: "Nome Inteiro" },
                    //{ field: "active", title: "Active", template: '<input type="checkbox" #= active ? "checked=checked" : ""#></input>' },
                    //template: "<input type='checkbox' disabled='disabled' #= active ? 'checked=\"checked\"' : '' # />"
                    {
                        command: [
                            { name: "edit", text: {edit: "Editar", update: "Atualizar", cancel: "Cancelar" } },
                            { name: "destroy", text: "Deletar" }
                        ],
                        title: "&nbsp;"
                    }
                ],
                editable: {
                    mode: "popup"
                },
                save: function () {
                    this.refresh();
                },
                edit: function () {

                },
                delete: function () {

                }
            };
            $scope.detailGridOptions = function (dataItem) {
                return {
                    dataSource: new kendo.data.DataSource({
                        transport: {
                            read: {
                                url: "/Pessoas/Pessoas",
                                dataType: "json"
                            }
                        },
                        schema: {
                            model: {
                                id: "Id",
                                fields: {
                                    //Id: { type: "number", editable: false, nulllable: true },
                                    Nome: { type: "string", validation: { required: { message: "Campo nome é obrigatório" } } },
                                    Sobrenome: { type: "string" },
                                    Cpf: { type: "string" },
                                    Descricao: { type: "string" },
                                    Tipo: { type: "number" },
                                    NomeInteiro: { type: "string"}
                                }
                            }
                        }
                    }),
                    columns: [
                    //{ field: "Id", title: "ID", width: "40px", filterable: false },
                    { field: "Nome", title: "Nome", template: "{{dataItem.Nome}}" },
                    { field: "Sobrenome", title: "Sobrenome" },
                    { field: "Cpf", title: "Cpf", template: "{{ dataItem.Cpf | cpf }}" },
                    { field: "Descricao", title: "Descrição" },
                    { field: "Tipo", Title: "Tipo" },
                    { field: "NomeInteiro", Title: "Nome Inteiro" },
                    //{ field: "active", title: "Active", template: '<input type="checkbox" #= active ? "checked=checked" : ""#></input>' },
                    //template: "<input type='checkbox' disabled='disabled' #= active ? 'checked=\"checked\"' : '' # />"
                    {
                        command: [
                            { name: "edit", text: { edit: "Editar", update: "Atualizar", cancel: "Cancelar" } },
                            { name: "destroy", text: "Deletar" }
                        ],
                        title: "&nbsp;"
                    }
                    ]
                }
            }

        });










angular.module("KendoDemos", ["kendo.directives"])
        .controller("MyCtrl", function ($scope) {
            $scope.mainGridOptions = {
                dataSource: {
                    type: "odata",
                    transport: {
                        read: "https://demos.telerik.com/kendo-ui/service/Northwind.svc/Employees"
                    },
                    pageSize: 5,
                    serverPaging: true,
                    serverSorting: true
                },
                filterable: { mode: "row" },
                sortable: true,
                groupable: true,
                pageable: true,
                dataBound: function () {
                    this.expandRow(this.tbody.find("tr.k-master-row").first());
                },
                toolbar: ["create"],
                columns: [
                    { field: "FirstName", title: "First Name", width: "120px" },
                    { field: "LastName", title: "Last Name", width: "120px" },
                    { field: "Country", width: "120px" },
                    { field: "City", width: "120px" },
                    { field: "Title" },
                    { command: ["edit", "destroy"], title: "&nbsp;", width: "250px" }
                ],
                editable: "popup"
            };

            $scope.detailGridOptions = function (dataItem) {
                return {
                    dataSource: {
                        type: "odata",
                        transport: {
                            read: "https://demos.telerik.com/kendo-ui/service/Northwind.svc/Orders"
                        },
                        serverPaging: true,
                        serverSorting: true,
                        serverFiltering: true,
                        pageSize: 5,
                        filter: { field: "EmployeeID", operator: "eq", value: dataItem.EmployeeID }
                    },
                    scrollable: false,
                    sortable: true,
                    pageable: true,
                    columns: [
                    { field: "OrderID", title: "ID", width: "56px" },
                    { field: "ShipCountry", title: "Ship Country", width: "110px" },
                    { field: "ShipAddress", title: "Ship Address" },
                    { field: "ShipName", title: "Ship Name", width: "190px" }
                    ]
                };
            };
        });