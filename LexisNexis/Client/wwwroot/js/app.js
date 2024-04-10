
function highlightBorders(controls) {
    $.each(controls, function (index, item) {
        $('#'+item).css("border", "2px solid red");
    });
}

//function animate() {
//    $("#box").animate(
//        { left: '500px' });
//}