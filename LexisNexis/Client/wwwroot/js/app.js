
function highlightBorders(controls) {
    $.each(controls, function (index, item) {
        $('#'+item).css("border", "2px solid red");
    });
}

function openFileInNewTab(array, mimeType) {
    let blob = new Blob([array], { type: mimeType });
    let blobUrl = URL.createObjectURL(blob);
   
    window.open(blobUrl, '_blank');
    //window.open("https://www.ford.com", '_blank');
    URL.revokeObjectURL(blobUrl);
}
