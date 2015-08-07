function commentSave(commentUserId, commentNote, commentReplyId, commentExceptId, url) {
    var btn = Ladda.create(document.querySelector('#commentSave'));
    btn.start();

    var data = { commentUserId: commentUserId, commentNote: commentNote, commentReplyId: commentReplyId, commentExceptId: commentExceptId };

    $.ajax({
        type: "POST",
        url: url,
        data: data,
        success: function (result) {
            console.log(result);
          btn.stop();

            if (result) {
                    $("#commentSave>span").text("Yorumunuz gönderilmiştir...").parent().addClass("btn-disabled").attr('disabled', 'disabled');

            } else {
                $("#commentSave>span").text("Hata meydana geldi. Daha sonra tekrar deneyiniz...").parent().addClass("btn-disabled").attr('disabled', 'disabled');
            }

          
        }
    });
}
$(document).ready(function () {
    jQuery.validator.setDefaults({
        debug: true,
        success: "valid",
        highlight: function (element) {
            $(element).closest('.form-group').addClass('has-error');
        },
        unhighlight: function (element) {
            $(element).closest('.form-group').removeClass('has-error');
        },
        errorElement: 'span',
        errorClass: 'help-block',
        errorPlacement: function (error, element) {
            if (element.parent('.input-group').length) {
                error.insertAfter(element.parent());
            } else {
                error.insertAfter(element);
            }
        }
    });
})