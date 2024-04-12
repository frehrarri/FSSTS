

$(function () {
    $("#badUsername").hide();
    $("#badPassword").hide();
});

function login(requestDTO: LoginRequestDTO) {
    $.ajax({
        url: 'Login/Login',
        data: requestDTO,
        type: 'POST',
        dataType: 'json'
    }).done(function () {

    });
}

function validateLogin() {
    let username: string = <string>$("#inputUsername").val();
    let password: string = <string>$("#inputPassword").val();
    let expectedUsername: string = "dave";
    let expectedPassword: string = "1234"
    let save: boolean = true;

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
        let requestDTO = new LoginRequestDTO(username, password);
        login(requestDTO);
    }
}

class LoginRequestDTO
{
    UserName: string;
    Password: string;

    constructor(username: string, password: string) {
        this.UserName = username;
        this.Password = password;
    }
    
}

