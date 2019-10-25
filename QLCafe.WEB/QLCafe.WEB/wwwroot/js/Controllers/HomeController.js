var homeController = {
    init: function () {
        homeController.registerEvent();
    },
    registerEvent: function () {
        homeController.loadData();
    },
    loadData: function () {
        $.ajax({
            url: '/Products/ProductsGetAlll',
            type: 'GET',
            dataType: 'json',
            success: function (response) {
                var data = response.data;
                var html = '';
                var template = $('#data-template').html();
                debugger;
                $.each(data, function (i, item) {
                    html += Mustache.render(template, {
                        ID: item.iD,
                        TypeID: item.typeID,
                        UnitID: item.unitID,
                        Name: item.name,
                        Price: item.price
                 
                    });
                });
                $('#tblData').html(html);
            }
        });

    }
}
homeController.init();