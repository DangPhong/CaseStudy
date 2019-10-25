var products = products || {};
$(document).ready(function () {
    products.init();
});

products.init = function () {
    products.darawProducts();
};

products.darawProducts = function () {
    $.ajax({
        url: 'Products/ProductsGetAlll',
        type: 'GET',
        dataType: 'json',
        success: function (response) {}
    });
};
