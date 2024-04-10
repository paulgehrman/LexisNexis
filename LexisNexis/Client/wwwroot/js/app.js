function showAlert() {
    alert("hello");
}

function displayBorder() {
    $("#accordion").css("border", "3px solid red");
}

function slide() {
    $("#accordion").slideDown(2000);
}

function makeBold() {
    $("#accordion").css("font-weight", "bold");
}

function animate() {
    $("#box").animate(
        { left: '500px' });
}