function confirmaDelete(uniqueId, isDeleteClicked) 
{
    var deleteSpan = 'deleteSpan_' + uniqueId;
    var confirmaDeleteSpan = 'confirmaDeletaSpan_' + uniqueId;
    if (isDeleteClicked) {
        $('#' + deleteSpan).hide();
        $('#' + confirmaDeleteSpan).show();
    } else {
        $('#' + deleteSpan).show();
        $('#' + confirmaDeleteSpan).hide();
    }
}