﻿var cartList = $("#cart-list");
var price;
var totalPrice;
var cartUri = '../api/cart/';
var shoppingCartImage = $("#emptyShoppingCart");

$(document).ready(function () {
    cartList.hide();
    $('.deleteItem').click(function () {
        var item = $(this).parent();
        $(this).parent().slideUp(500, function () {
            item.remove();
            getCount();
        });
    });
});

function showCart() {
    $("#showCart").hide();
    $("#emptyShoppingCart").fadeOut(1000, function () {
        cartList.fadeIn(1000);
    });



};

function hideCart() {
    cartList.fadeOut(1000, function () {
        $("#showCart").fadeIn(1000);
        shoppingCartImage.fadeIn(1000);
    });
}

function deleteItem(productId, userId, price) {
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

