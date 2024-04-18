
$(function () {
    $(".Error").hide();

    $("#btnValidate").on("click", validate);

});

function register(accountRequestDTO) {

    $.ajax({
        url: 'ValidateRegistration',
        data: accountRequestDTO,
        type: 'POST',
        dataType: 'json'
    }).done(function () {
    });
}
function validate() {

    $(".Error").hide();
    var errors = [];

    var username = $("#inputUsername").val();
    var password = $("#inputPassword").val();
    var recoveryQuestion1 = $("#recoveryQuestion1").val();
    var recoveryQuestion2 = $("#recoveryQuestion2").val();
    var recoveryQuestion3 = $("#recoveryQuestion3").val();
    var recoveryAnswer1 = $("#recoveryAnswer1").val();
    var recoveryAnswer2 = $("#recoveryAnswer2").val();
    var recoveryAnswer3 = $("#recoveryAnswer3").val();
    var firstName = $("#firstName").val();
    var lastName = $("#lastName").val();
    var streetAddress = $("#streetAddress").val();
    var city = $("#city").val();
    var zip = $("#zip").val();
    var email = $("#email").val();
    var phone = $("#phone").val();
    var isValid = true;

    if (username.length < 4 || username.length > 20) {
        isValid = false;
        errors.push(IncorrectUsernameLength);
    }
    else if (!username) {
        isValid = false;
        errors.push(UsernameNotValid);
    }

    //check username for non-alphanumeric characters
    if (/^[a-zA-Z0-9]+$/.test(username) == false) {
        isValid = false;
        errors.push(UsernameCharactersInvalid);
    }

    if (password.length < 8 || password.length > 20) {
        isValid = false;
        errors.push(IncorrectPasswordLength);
    }
    else if (!password) {
        isValid = false;
        errors.push(PasswordNotValid);
    }

    //if password does not contain upper and lowercase letters, numbers, and special characters
    if (/^(?=.*\d)(?=.*[!@#$%^&*])(?=.*[a-z])(?=.*[A-Z]).{8,}$/.test(password) == false) {
        isValid = false;
        errors.
        push(PasswordCharactersNotValid);
    }

    if (!recoveryQuestion1 || !recoveryQuestion2 || !recoveryQuestion3) {
        isValid = false;
        errors.push(RecoveryQuestionEmpty);
    }

    if (!recoveryAnswer1 || !recoveryAnswer2 || !recoveryAnswer3) {
        isValid = false;
        errors.push(RecoveryAnswerEmpty);
    }

    if (!firstName) {
        isValid = false;
        errors.push(FirstNameEmpty);
    }

    if (!lastName) {
        isValid = false;
        errors.push(LastNameEmpty);
    }

    if (!streetAddress || !city || !zip) {
        isValid = false;
        errors.push(AddressEmpty);
    }
  
    if (!email) {
        isValid = false;
        errors.push(EmailEmpty);
    }

    //check if valid email format
    if (/^(([^<>()[\]\\.,;:\s@"]+(\.[^<>()[\]\\.,;:\s@"]+)*)|.(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/.test(email) == false) {
        isValid = false;
        errors.push(InvalidEmailFormat);
    }

    //check for non numerical characters
    if (/^\d+$/.test(phone.toString()) == false) {
        isValid = false;
        errors.push(InvalidPhoneFormat);
    }

    if (phone.toString().length !== 10) {
        isValid = false;
        errors.push(InvalidPhoneLength);
    }
    else if (!phone) {
        isValid = false;
        errors.push(PhoneEmpty);
    }

    errors = errors.join("<br />");
    $("#errorList").html(errors);

    if (isValid) {
        const accountRequestDTO = {
            Username: username
            , Password: password
            , RecoveryQuestion1: recoveryQuestion1
            , RecoveryQuestion2: recoveryQuestion2
            , RecoveryQuestion3: recoveryQuestion3
            , RecoveryAnswer1: recoveryAnswer1
            , RecoveryAnswer2: recoveryAnswer2
            , RecoveryAnswer3: recoveryAnswer3
            , FirstName : firstName
            , LastName : lastName
            , StreetAddress : streetAddress
            , City : city
            , ZipCode : zip
            , Email : email
            , Phone : phone
        };

        register(accountRequestDTO);
    }
    else {
        $("#errorList").show();
    }


}

