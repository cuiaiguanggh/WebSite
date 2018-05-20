$(function () {
    var index = $("#selectIndex").val();
    $("ul.navbar-nav li").removeClass("active").eq(index).addClass("active");
})