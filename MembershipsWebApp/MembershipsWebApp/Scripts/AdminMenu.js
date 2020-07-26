//Edited
//Document ready function
//targeting the data-admin-menu attribute from the Admin View.
//Funtion to open and close admin menu with dropdown list of items.
$(function () {
    $('[data-admin-menu]').hover(function(){
        $('[data-admin-menu]').toggleClass('open'); 
    });
});