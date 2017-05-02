$(document).ready(function () {

    var scrollCallback = function() {

        var
            controlArea = $('#control-area'),
            popupMenu = $('.menu-placeholder'),
            scrollTop = $(window).scrollTop(),
            parallaxSections = $('section[data-type="background"]');

        if (parallaxSections.length > 0) {
            parallaxSections.each(function () {
                var section = $(this);
                var yPos = -(scrollTop / section.data('speed'));
                var coords = 'center ' + yPos + 'px';
                section.css({ backgroundPosition: coords });
            });
        }

        if (scrollTop > 31) {
            controlArea.addClass('fixed');
            popupMenu.addClass('fixed');
        }
        else {
            controlArea.removeClass('fixed');
            popupMenu.removeClass('fixed');
        }
    };

    $(window).bind('scroll', scrollCallback);
    scrollCallback();
});