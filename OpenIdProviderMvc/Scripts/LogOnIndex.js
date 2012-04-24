
LOGIN_BUTTON = ".loginButton";
USER_TEXTBOX = ".user";
PASSWORD_TEXTBOX = ".password";

$(document).ready(function () {

    LogOnForm.subscribeToEvents();

});

var LogOnForm = {

    subscribeToEvents: function () {

        $(LOGIN_BUTTON).click(function () {

            var user = $(USER_TEXTBOX).val();

            var password = $(PASSWORD_TEXTBOX).val();

            
        });

    }

};


