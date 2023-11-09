// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

/*
 *  Global code ------------------------------------------------
 */

var urlPathArr = window.location.pathname.split('/');

//// Toggle checkbox values for site
//$(document).on("click", "input[type='checkbox']", function (e) {
//        if ($(this).prop("checked") == true) {
//            $(this).attr("value", "true");
//        } else {
//            $(this).attr("value", "false");
//        }
//    });

/*
 *  Auto adjust textarea to fit text
 *  https://stackoverflow.com/questions/454202/creating-a-textarea-with-auto-resize
 */
const tx = document.getElementsByTagName("textarea");
for (let i = 0; i < tx.length; i++) {
    tx[i].setAttribute("style", "height:" + (tx[i].scrollHeight) + "px;overflow-y:hidden;");
    tx[i].addEventListener("input", OnInput, false);
}

function OnInput() {
    this.style.height = 0;
    this.style.height = (this.scrollHeight) + "px";
}


/*
 *  iBelongBaskets -> Create & Edit pages ------------------------
 */

// Filter displayed products
function filterProducts() {
    let input, filter, filterElms, txtValue;
    input = document.getElementById("search-txt");
    filter = input.value.toUpperCase();
    filterElms = document.querySelectorAll(".filter-elms");

    for (var i = 0; i < filterElms.length; i++) {
        txtValue = filterElms[i].childNodes[1].childNodes[3].textContent || filterElms[i].childNodes[1].childNodes[3].innerText;
        if (txtValue.toUpperCase().indexOf(filter) > -1) {
            filterElms[i].style.display = "";
        } else {
            filterElms[i].style.display = "none";
        }
    }
}

/*
 *  ShoppingList -> Create & Edit pages ------------------------
 */

// Filter displayed categories
function filterCategories(category) {
    let input, filter, filterElms, txtValue;
    input = document.getElementById(`search-${category}`);
    filter = input.value.toUpperCase();
    filterElms = document.querySelectorAll(`.filter-${category}`);

    for (var i = 0; i < filterElms.length; i++) {
        txtValue = filterElms[i].childNodes[3].textContent || filterElms[i].childNodes[3].innerText;
        if (txtValue.toUpperCase().indexOf(filter) > -1) {
            filterElms[i].style.display = "";
        } else {
            filterElms[i].style.display = "none";
        }
    }
}