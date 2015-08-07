function commentSave(commentUserId, commentNote, commentReplyId, commentExceptId, url) {
    var l = Ladda.create(document.querySelector('#commentSaveBtn'));
    l.start();
    var data = { commentUserId: commentUserId, commentNote: commentNote, commentReplyId: commentReplyId, commentExceptId: commentExceptId };

    $.ajax({
        type: "POST",
        url: url,
        data: data,
        success: function (result) {
            if (result) {
                l.stop();
                $("#commentSaveBtn>span").text("yorumunuz gönderilmiştir.").parent().addClass("disabled").attr("disabled", "disabled");


                $("#approvalName").text("fatih");
                $("#approvalImage").attr("src");
                $("#approvalNote").html(commentNote);
                $(".approval").slideDown("slow");


            } else {
            }
        }
    });
}

$(document).ready(function () {
    $.validator.setDefaults({
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

    $("#commentSaveForm").validate({
        rules: {
            commentNote: {
                required: true
            }
        },
        messages: {
            commentNote: "Lütfen yorumunuzu yazınız.."
        }
    });
})