function AddToCart(menuItemId, count, isGridUpdate) {
    if (count === null || count == undefined) {
        count = 1;
        isGridUpdate = false;
    }

    var dataToSend = { 'menuItemId': menuItemId, 'count': count, 'isGridUpdate': isGridUpdate };
    callAsyncAjaxMethod("/Cart/AddToCart", dataToSend, function (response) {

        if (response.success === true) {
            $('#cartSummary').html(response.data[0].Value);
        }
        else {

        }

    });
}
function RemoveFromCart(menuItemId, isRefreshPage) {
    if (menuItemId === null || menuItemId === undefined) {
        return;
    }
    if (isRefreshPage === null || isRefreshPage === undefined) {
        isRefreshPage = false;
    }
    var dataToSend = { 'menuItemId': menuItemId, 'isRefreshPage': isRefreshPage };
    callAsyncAjaxMethod("/Cart/RemoveFromCart", dataToSend, function (response) {
        if (isRefreshPage === true) {
            window.location.href = "";
        }
        if (response.success === true) {
            $('#cartSummary').html(response.data[0].Value);
        }
        else {
        }

    });
}
function onNumberOfProductPress(args, menuitemId) {
    //if user Enter
    if (args.charCode == 13) {
        //update
        var numberOfProduct = args.target.value;
        //if this is not a number
        if (!isNaN(numberOfProduct)) {
            AddToCart(menuitemId, numberOfProduct, true);
        }
    }
}
function onAddToCartMenuItemPress(menuitemId) {
    var numberOfProduct = $('#input-quantity').val();
    if (isNaN(numberOfProduct)) {
        return;
    }
    if (numberOfProduct === '' || numberOfProduct === null || numberOfProduct === undefined) {
        return;
    }
    AddToCart(menuitemId, numberOfProduct, true);
}