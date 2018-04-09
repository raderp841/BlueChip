
var uri = '../api/products';

$(document).ready(function () {
    $('#showProductLines').hide();
});

function formatItem(item) {

    return item.Named + ': $' + item.Price;
}

function find(id) {
    $.getJSON(uri + '/' + id)
        .done(function (data) {

            $.each(data, function (key, item) {
                var container = $('#products');
                $('<div>',
                    { 'class': 'productImage' })
                    .appendTo($('#products'));

                $('<h2>',
                    {
                        text: formatItem(item),
                        "class": ""
                    })
                    .appendTo($(container).children().last());


                $('<img>',
                    {
                        "src": "../Content/Images/" + item.PictureURL,
                        "class": "insideImage img-responsive"
                    })
                    .appendTo($(container).children().children().last());



                $('<button>',
                    {
                        text: 'Add to Cart',
                        'class': 'btn btn-success',
                        'click': function () {
                            console.log(item.Id);
                            $.ajax({
                                url: '../Home/SaveItemForUser',
                                data: { productId: item.Id }
                            }).done(function () {
                                location.reload(true);
                            });
                        }
                    })
                    .appendTo($(container).children().last());

            });

        });
    $('.productLines').hide();
    $('#showProductLines').show();
};
function showProductLines() {
    $('#showProductLines').hide();
    $('.productLines').show();
    $('#products').empty();
};

function flipCard() {
    $(this).flip();
};