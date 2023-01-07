'use strict';
$(document).ready(function () {

    $(document).on('click', 'a.tour', function(){
        Tour.run(
			[
				{
					element: $('nav.navbar'),
					content: 'این نوار منو است.',
					position: 'bottom'
				},
				{
					element: $('.side-menu'),
					content: 'این منوی کناری است.',
					position: 'left'
				},
				{
					element: $('aside'),
					content: 'این نوار منوی کناری است.',
					position: 'left'
				},
				{
					element: $('.page-header'),
					content: 'این عنوان اصلی صفحه است.',
					position: 'bottom'
				},
				{
					element: $('.tour-card'),
					content: 'این ناحیه ای است که محتوا را در بر می گیرد.',
					position: 'top'
				},
				{
					element: $('.jumbotron'),
					content: 'اما می تواند در بالا باشد.',
					position: 'top'
				},
				{
					element: $('.jumbotron a.btn'),
					content: 'اما می تواند در بالا باشد.',
					position: 'right'
				}
			],
			{
				language: 'fa'
			}
		);
    });

});