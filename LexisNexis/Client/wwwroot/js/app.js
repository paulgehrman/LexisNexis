//function showAlert() {
//    alert("hello");
//}

function highlightBorders(controls) {
    $.each(controls, function (index, item) {
        $('#'+item).css("border", "2px solid red");
    });


  //  $("#recipetitle").css("border", "2px solid red");
  //  $("#recipedescription").css("border", "2px solid red");
}

//function makeBold() {
//    $("#accordion").css("font-weight", "bold");
//}

//function animate() {
//    $("#box").animate(
//        { left: '500px' });
//}