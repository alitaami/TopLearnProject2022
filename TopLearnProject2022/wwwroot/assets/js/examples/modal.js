'use strict';
$(document).ready(function () {

	$('#exampleModal').on('show.bs.modal', function (event) {
		var button = $(event.relatedTarget),
			recipient = button.data('whatever'),
			modal = $(this);

		modal.find('.modal-title').text('پیام جدید به ' + recipient);
		modal.find('.modal-body input').val(recipient);
	});

});