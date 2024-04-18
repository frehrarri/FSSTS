$(function () {
    $("#badUsername").hide();
    $("#badPassword").hide();

    $("#btnValidateLogin").on("click", validateLogin());
});

function login(requestDTO) {
    $.ajax({
        url: 'Login/Login',
        data: requestDTO,
        type: 'POST',
        dataType: 'json'
    }).done(function () {
    });
}
function validateLogin() {
    var username = $("#inputUsername").val();
    var password = $("#inputPassword").val();
    var expectedUsername = "dave";
    var expectedPassword = "1234";
    var save = true;
    if (!username) {
        save = false;
        //return;
    }
    if (!password) {
        //save = false;
        return;
    }
    if (username != expectedUsername) {
        //save = false;
        $("#badPassword").show();
    }
    if (password != expectedPassword) {
        //save = false;
        $("#badUsername").show();
    }
    if (save) {
        const requestDTO = {
            Username: username
            , Password: password
        };

        login(requestDTO);
    }
}
