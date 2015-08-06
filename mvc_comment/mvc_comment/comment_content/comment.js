function commentSave(commentUserId,commentNote,commentReplyId, commentExceptId, url) {
  

    var data = { commentUserId: commentUserId, commentNote: commentNote, commentReplyId: commentReplyId, commentExceptId: commentExceptId };

    $.ajax({
        type: "POST",
        url: url,
        data: data,
        success: function (result) {
            console.log(result);
        }
    });
}