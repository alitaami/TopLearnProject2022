'use strict';

(function ($) {

    $(document).on('click', '.layout-builder .layout-builder-toggle', function () {
        $('.layout-builder').toggleClass('show');
    });

    $(window).on('load', function () {
        setTimeout(function () {
            $('.layout-builder').removeClass('show');
        }, 500);
    });

    $('body').append(''+
    '<div class="layout-builder show">'+
        '<div class="layout-builder-toggle shw">'+
            '<i class="ti-settings"></i>'+
        '</div>'+
        '<div class="layout-builder-toggle hdn">'+
            '<i class="ti-close"></i>'+
        '</div>'+
        '<div class="layout-builder-body">'+
            '<h5>سفارشی سازی</h5>'+
            '<div class="mb-3">'+
                '<p>طرح</p>'+
                '<div class="custom-control custom-radio">'+
                  '<input type="radio" class="custom-control-input" name="layout" id="horizontal-side-menu" data-layout="horizontal-side-menu">'+
                  '<label class="custom-control-label" for="horizontal-side-menu">فهرست افقی</label>'+
                '</div>'+
                '<div class="custom-control custom-radio">'+
                  '<input type="radio" class="custom-control-input" name="layout" id="icon-side-menu" data-layout="icon-side-menu">'+
                  '<label class="custom-control-label" for="icon-side-menu">فهرست آیکن</label>'+
                '</div>'+
                '<div class="custom-control custom-radio">'+
                  '<input type="radio" class="custom-control-input" name="layout" id="dark-side-menu" data-layout="dark-side-menu">'+
                  '<label class="custom-control-label" for="dark-side-menu">فهرست تیره</label>'+
                '</div>'+
                '<div class="custom-control custom-radio">'+
                  '<input type="radio" class="custom-control-input" name="layout" id="hidden-side-menu" data-layout="hidden-side-menu">'+
                  '<label class="custom-control-label" for="hidden-side-menu">فهرست پنهان</label>'+
                '</div>'+
                '<div class="custom-control custom-radio">'+
                  '<input type="radio" class="custom-control-input" name="layout" id="layout-container-1" data-layout="layout-container icon-side-menu">'+
                  '<label class="custom-control-label" for="layout-container-1">طرح دربرگیرنده 1</label>'+
                '</div>'+
                '<div class="custom-control custom-radio">'+
                  '<input type="radio" class="custom-control-input" name="layout" id="layout-container-2" data-layout="layout-container horizontal-side-menu">'+
                  '<label class="custom-control-label" for="layout-container-2">طرح دربرگیرنده 2</label>'+
                '</div>'+
                '<div class="custom-control custom-radio">'+
                  '<input type="radio" class="custom-control-input" name="layout" id="layout-container-3" data-layout="layout-container hidden-side-menu">'+
                  '<label class="custom-control-label" for="layout-container-3">طرح دربرگیرنده 3</label>'+
                '</div>'+
                '<div class="custom-control custom-radio">'+
                  '<input type="radio" class="custom-control-input" name="layout" id="dark-1" data-layout="dark">'+
                  '<label class="custom-control-label" for="dark-1">طرح تیره 1</label>'+
                '</div>'+
                '<div class="custom-control custom-radio">'+
                  '<input type="radio" class="custom-control-input" name="layout" id="dark-2" data-layout="layout-container dark icon-side-menu">'+
                  '<label class="custom-control-label" for="dark-2">طرح تیره 2</label>'+
                '</div>'+
                '<div class="custom-control custom-radio">'+
                  '<input type="radio" class="custom-control-input" name="layout" id="dark-3" data-layout="layout-container dark horizontal-side-menu">'+
                  '<label class="custom-control-label" for="dark-3">طرح تیره 3</label>'+
                '</div>'+
                '<div class="custom-control custom-radio">'+
                  '<input type="radio" class="custom-control-input" name="layout" id="dark-4" data-layout="layout-container dark hidden-side-menu">'+
                  '<label class="custom-control-label" for="dark-4">طرح تیره 4</label>'+
                '</div>'+
            '</div>'+
            '<button id="btn-layout-builder-reset" class="btn btn-danger btn-uppercase">بازنشانی</button>'+
            '<div class="layout-alert mt-3">'+
                '<i class="fa fa-warning m-l-5 text-warning"></i>برخی گزینه های قالب در صورت ترکیب با یکدیگر در صورتی که همخوانی نداشته باشند قابل نمایش نخواهند بود. بنابراین توصیه می شود گزینه های قالب را جدا جدا امتحان کنید.'+
            '</div>'+
        '</div>'+
    '</div>');

    var site_layout = localStorage.getItem('site_layout');
    $('body').addClass(site_layout);

    $('.layout-builder .layout-builder-body input[type="radio"][data-layout="' + $('body').attr('class') + '"]').prop('checked', true);

    $('.layout-builder .layout-builder-body input[type="radio"]').click(function () {
        var class_names = '';

        $('.layout-builder .layout-builder-body input[type="radio"]:checked').each(function () {
            class_names += ' ' + $(this).data('layout');
        });

        localStorage.setItem('site_layout', class_names);

        window.location.href = (window.location.href).replace('#', '');
    });

    $(document).on('click', '#btn-layout-builder', function () {

    });

    $(document).on('click', '#btn-layout-builder-reset', function () {
        localStorage.removeItem('site_layout');
        localStorage.removeItem('site_layout_dark');

        window.location.href = (window.location.href).replace('#', '');
    });

    $(window).on('load', function () {
        if ($('body').hasClass('horizontal-side-menu') && $(window).width() > 768) {
            if ($('body').hasClass('layout-container')) {
                $('.side-menu .side-menu-body').wrap('<div class="container"></div>');
            } else {
                $('.side-menu .side-menu-body').wrap('<div class="container-fluid"></div>');
            }
            setTimeout(function () {
                $('.side-menu .side-menu-body > ul').append('<li><a href="#"><span>سایر</span></a><ul></ul></li>');
            }, 100);
            $('.side-menu .side-menu-body > ul > li').each(function () {
                var index = $(this).index(),
                    $this = $(this);
                if (index > 7) {
                    setTimeout(function () {
                        $('.side-menu .side-menu-body > ul > li:last-child > ul').append($this.clone());
                        $this.addClass('d-none');
                    }, 100);
                }
            });
        }
    });

    $(document).on('click', '[data-attr="layout-builder-toggle"]', function () {
        $('.layout-builder').toggleClass('show');
        return false;
    });

})(jQuery);