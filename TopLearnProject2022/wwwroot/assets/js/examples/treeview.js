'use strict';
$(document).ready(function () {

	$('#jstree_demo1').jstree({'core' : {
		'data' : [
			{
				"text" : "لورم ایپسوم متن ساختگی",
				"children" : [
					{ "text" : "انتخاب شده در ابتدا", "state" : { "selected" : true } },
					{ "text" : "آیکن سفارشی", "icon" : "https://jstree.com/tree-icon.png" },
					{ "text" : "باز شده در ابتدا", "state" : { "opened" : true }, "children" : [ "یک گره دیگر" ] },
					{ "text" : "کلاس آیکن سفارشی", "icon" : "fa fa-leaf" }
				]
			},
			"لورم ایپسوم متن"
		]
	}});

	$('#jstree_demo2').jstree({'plugins':["wholerow"], 'core' : {
		'data' : [
			{
				"text" : "لورم ایپسوم متن ساختگی",
				"children" : [
					{ "text" : "انتخاب شده در ابتدا", "state" : { "selected" : true } },
					{ "text" : "آیکن سفارشی", "icon" : "https://jstree.com/tree-icon.png" },
					{ "text" : "باز شده در ابتدا", "state" : { "opened" : true }, "children" : [ "یک گره دیگر" ] },
					{ "text" : "کلاس آیکن سفارشی", "icon" : "fa fa-leaf" }
				]
			},
			"لورم ایپسوم متن"
		]
	}});

	$('#jstree_demo3').jstree({'plugins':["wholerow", "checkbox"], 'core' : {
		'data' : [
			{
				"text" : "لورم ایپسوم متن ساختگی",
				"children" : [
					{ "text" : "انتخاب شده در ابتدا", "state" : { "selected" : true } },
					{ "text" : "آیکن سفارشی", "icon" : "https://jstree.com/tree-icon.png" },
					{ "text" : "باز شده در ابتدا", "state" : { "opened" : true }, "children" : [ "یک گره دیگر" ] },
					{ "text" : "کلاس آیکن سفارشی", "icon" : "fa fa-leaf" }
				]
			},
			"لورم ایپسوم متن"
		]
	}});

});