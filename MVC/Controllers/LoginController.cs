using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using BLL.Interfaces;
using DTO.AccountInfo;
using DTO.Login;
using DTO.RequestDTO;
using Utility;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using MVC.Models;
using DTO.ResponseDTO;

namespace MVC.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;
        private readonly ILoginBLL _loginBLL;

        public LoginController(ILogger<LoginController> logger, ILoginBLL loginBLL)
        {
            _logger = logger;
            _loginBLL = loginBLL;
        }

        public IActionResult Login(LoginRequestDTO requestDTO)
        {
            LoginResponseDTO responseDTO = ValidateLogin(requestDTO);

            if (!responseDTO.Authorized)
            {
                return Json(responseDTO); //invalid credentials - validation message
            }

            return View(); // homepage
        }

        public LoginResponseDTO ValidateLogin(LoginRequestDTO requestDTO)
        {
            return _loginBLL.ValidateLoginCredentials(requestDTO);
        }

        public IActionResult Register(AccountRequestDTO accountRequestDTO)
        {
            return View();
        }

        [HttpPost]
        public IActionResult ValidateRegistration(AccountRequestDTO accountRequestDTO)
        {
            var responseDTO = _loginBLL.ValidateRegistration(accountRequestDTO);

            if (responseDTO.ValidationErrors.Any())
            {
                return Json(responseDTO); //invalid registration - validation messages
            }

            _loginBLL.RegisterAccount(accountRequestDTO);
            return View();
        }

    }
}