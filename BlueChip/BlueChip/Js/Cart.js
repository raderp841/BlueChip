var cartList = $("#cart-list");
var price;
var totalPrice;
var cartUri = '../api/cart/';

$(document).ready(function () {
    cartList.hide();
    $('.deleteItem').click(function () {
        $(this).parent().remove();
        getCount();
    });
});

function showCart() {
    cartList.show();
    $("#showCart").hide();
};

function hideCart() {
    cartList.hide();
    $("#showCart").show();
}

function deleteItem(productId, userId, price) {
    console.log(productId);
    console.log(userId);
    getTotalPrice();
    console.log(totalPrice);
    changeSub(price);
    $("#total").text(totalPrice.toFixed(2));
    console.log(price);
    deleteFromDB(userId, productId);
};

function getCount() {
    var count = $(".deleteItem").length;
    var countText = $(".cartCount");
    countText.text("You have " + count + " items");
};

function changeSub(price) {
    totalPrice -= parseFloat(price, 10);
};

function getTotalPrice() {
    totalPrice = parseFloat($("#total").html(), 10);
    console.log(totalPrice);
}


function deleteFromDB(userId, productId) {
    var ids = userId + 'a' + productId;
    var urlcart = cartUri + ids;
    $.ajax({
        url: urlcart,
        type: 'POST',
        data: { userId: userId, productId: productId },
        dataType: 'json',
        success: function (data) {
            console.log("working");
        }
    });

};

