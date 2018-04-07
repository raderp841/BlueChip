var cartList = $("#cart-list");
var price;
var totalPrice;

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

function deleteItem(productId, userId, price) {
    console.log(productId);
    console.log(userId);
    getTotalPrice();
    console.log(totalPrice);
    changeSub(price);
    $("#total").text(totalPrice);
    console.log(price);
};

function getCount() {
    var count = $(".deleteItem").length;
    var countText = $(".cartCount");
    countText.text("You have " + count + " items");
};

function changeSub(price) {
    totalPrice -= price;
};

function getTotalPrice() {
    totalPrice = $("#total").html();
    console.log(totalPrice);
}




