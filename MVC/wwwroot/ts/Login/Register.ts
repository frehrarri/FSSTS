import { Constants } from '../constants';

$(function () {
    $(".Error").hide();
});


function register(accountRequestDTO: AccountRequestDTO) {
    $.ajax({
        url: 'ValidateRegistration',
        data: accountRequestDTO,
        type: 'POST',
        dataType: 'json'
    }).done(function () {

    });
}

function validate() {
    let CONSTANTS: Constants;
    let errors: string[] = new Array();

    let username: string = <string>$("#inputUsername").val();
    let password: string = <string>$("#inputPassword").val();
    let recoveryQuestion1: string = <string>$("#recoveryQuestion1").val();
    let recoveryQuestion2: string = <string>$("#recoveryQuestion2").val();
    let recoveryQuestion3: string = <string>$("#recoveryQuestion3").val();
    let recoveryAnswer1: string = <string>$("#recoveryAnswer1").val();
    let recoveryAnswer2: string = <string>$("#recoveryAnswer2").val();
    let recoveryAnswer3: string = <string>$("#recoveryAnswer3").val();

    let firstName: string = <string>$("#firstName").val();
    let lastName: string = <string>$("#lastName").val();
    let streetAddress: string = <string>$("#streetAddress").val();
    let city: string = <string>$("#city").val();
    let zip: number = <number>$("#zip").val();
    let email: string = <string>$("#email").val();
    let phone: number = <number>$("#phone").val();

    let isValid: boolean = true;
   

    if (username.length < 4 || username.length > 20) {
        isValid = false;
        errors.push(CONSTANTS.IncorrectUsernameLength);
    }
    else if (!username) {
        isValid = false;
        errors.push(CONSTANTS.UsernameNotValid);
    }

    //check username for non-alphanumeric characters
    if (/^[a-zA-Z0-9]+$/.test(username)) {
        isValid = false;
        errors.push(CONSTANTS.UsernameCharactersInvalid);
    }
    
    if (password.length < 8 || password.length > 20) {
        isValid = false;
        errors.push(CONSTANTS.IncorrectPasswordLength);
    }
    else if (!password) {
        isValid = false;
        errors.push(CONSTANTS.PasswordNotValid);
    }

    //if password does not contain upper and lowercase letters, numbers, and special characters
    if (/^(?=.*\d)(?=.*[!@#$%^&*])(?=.*[a-z])(?=.*[A-Z]).{8,}$/.test(password) == false) {
        isValid = false;
        errors.push(CONSTANTS.PasswordCharactersNotValid);
    } 

    if (!recoveryQuestion1) {
        isValid = false;
        errors.push(CONSTANTS.RecoveryQuestionEmpty);
    }

    if (!recoveryQuestion2) {
        isValid = false;
        errors.push(CONSTANTS.RecoveryQuestionEmpty);
    }

    if (!recoveryQuestion3) {
        isValid = false;
        errors.push(CONSTANTS.RecoveryQuestionEmpty);
    }

    if (!recoveryAnswer1) {
        isValid = false;
        errors.push(CONSTANTS.RecoveryAnswerEmpty);
    }

    if (!recoveryAnswer2) {
        isValid = false;
        errors.push(CONSTANTS.RecoveryAnswerEmpty);
    }

    if (!recoveryAnswer3) {
        isValid = false;
        errors.push(CONSTANTS.RecoveryAnswerEmpty);
    }

    if (!firstName) {
        isValid = false;
        errors.push(CONSTANTS.FirstNameEmpty);
    }

    if (!lastName) {
        isValid = false;
        errors.push(CONSTANTS.LastNameEmpty);
    }

    if (!streetAddress) {
        isValid = false;
        errors.push(CONSTANTS.AddressEmpty);
    }

    if (!city) {
        isValid = false;
        errors.push(CONSTANTS.AddressEmpty);
    }

    if (!zip) {
        isValid = false;
        errors.push(CONSTANTS.AddressEmpty);
    }

    if (!email) {
        isValid = false;
        errors.push(CONSTANTS.EmailEmpty);
    }

    //check if valid email format
    if (/^(([^<>()[\]\\.,;:\s@"]+(\.[^<>()[\]\\.,;:\s@"]+)*)|.(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/.test(email) == false) {
        isValid = false;
        errors.push(CONSTANTS.InvalidEmailFormat);
    }

    //check for non numerical characters
    if (/^\d+$/.test(phone.toString()) == false) {
        isValid = false;
        errors.push(CONSTANTS.InvalidPhoneFormat);
    }
    
    if (phone.toString().length !== 10) {
        isValid = false;
        errors.push(CONSTANTS.InvalidPhoneLength);
    }
    else if (!phone) {
        isValid = false;
        errors.push(CONSTANTS.PhoneEmpty);
    }

    $(".errorList").text(errors.join("<br />"));//'<br />'

    if (isValid) {
        let accountRequestDTO = new AccountRequestDTO(
            username,
            password,
            recoveryQuestion1,
            recoveryQuestion2,
            recoveryQuestion3,
            recoveryAnswer1,
            recoveryAnswer2,
            recoveryAnswer3,
            firstName,
            lastName,
            streetAddress,
            city,
            zip,
            email,
            phone
        );

        register(accountRequestDTO);
    }
    
}

class AccountRequestDTO {

    Username: string;
    Password: string;
    RecoveryQuestion1: string;
    RecoveryQuestion2: string;
    RecoveryQuestion3: string;
    RecoveryAnswer1: string;
    RecoveryAnswer2: string;
    RecoveryAnswer3: string;
    FirstName: string;
    LastName: string;
    StreetAddress: string;
    City: string;
    ZipCode: number;
    Email: string;
    Phone: number;

    constructor(username: string,
        password: string,
        recoveryQuestion1: string,
        recoveryQuestion2: string,
        recoveryQuestion3: string,
        recoveryAnswer1: string,
        recoveryAnswer2: string,
        recoveryAnswer3: string,
        firstName: string,
        lastName: string,
        streetAddress: string,
        city: string,
        zip: number,
        email: string,
        phone: number)
    {
        this.Username = username;
        this.Password = password;
        this.RecoveryQuestion1 = recoveryQuestion1;
        this.RecoveryQuestion2 = recoveryQuestion2;
        this.RecoveryQuestion3 = recoveryQuestion3;
        this.RecoveryAnswer1 = recoveryAnswer1;
        this.RecoveryAnswer2 = recoveryAnswer2;
        this.RecoveryAnswer3 = recoveryAnswer3;
        this.FirstName = firstName;
        this.LastName = lastName;
        this.StreetAddress = streetAddress;
        this.City = city;
        this.ZipCode = zip;
        this.Email = email;
        this.Phone = phone;
    }

}

     