var app = (function () {
    return {
        notifiy: function (title, content, type,ShowCancelButton,confirmFunction,cancelFunction) {
            swal({
                title: title,
                text: content,
                type: type,
                showCancelButton: ShowCancelButton,
                //confirmButtonClass: "btn-danger",
                confirmButtonText: "نعم",
                cancelButtonText: "إلغاء",
                closeOnConfirm: true,
                closeOnCancel: true
            },
                function (isConfirm) {
                    if (isConfirm) {
                        if (confirmFunction)
                            confirmFunction();
                    } else {
                        if (cancelFunction)
                            cancelFunction();
                    }
                });
           
        }
    }
})();

$(".modal").on("hidden.bs.modal", function () {
    
    $("input,select").val('');
});