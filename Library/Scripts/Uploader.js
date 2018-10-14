(function ($) {
    $.fn.Uploader = function (userOptions) {
        var initialCode;
        var newCode;
        
        var $DOMBody = $("body", document);

        var defaults = {
            class: "fa fa-upload",
            img: "",
            multiple: false

        }


        var options = $.extend({}, defaults, userOptions);
        console.log(this);
        console.log(this.html());
        initialCode = this.html();
        var controlName = $(this).addClass("hidden").attr("name");
        var wrapperName = "wrapper-Uploader-" + controlName;
        newCode = `<div class='wrapper-Uploader' id='${wrapperName}'>
                    <a href="javascript:;" class="thumbnail">
                        <i class="fa fa-upload" aria-hidden="true"></i>
                    </a ></div > `
            ;

        $(this).empty();
        $(this).after(newCode);
        $this = this;

        $("#" + wrapperName).on("click", function () {
            $($this).click();
        });
        return this;
    }
    

})(jQuery)