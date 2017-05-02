$(function () {
    var path = window.location.pathname;
    if (path != "/") {
        $(".navbar-nav li").removeClass("active");
        $(".navbar-nav li").each(function () {
            var href = $(this).children().first().attr("href");
            if (path == href) {
                $(this).addClass("active");
            }
        });
    }
});