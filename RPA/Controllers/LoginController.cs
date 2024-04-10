using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using RPA.Models;
using RPABLL.Interfaces;
using RPADTO.AccountInfo;
using RPADTO.Login;
using RPADTO.RequestDTO;
using RPAUtility;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;

namespace RPA.Controllers
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

        public IActionResult Login()
        {
            //VerifyLoginCredentials();

            return View();
        }

        public IActionResult ValidateLogin(LoginRequestDTO requestDTO)
        {
            LoginResponseDTO loginResponseDTO = _loginBLL.ValidateLoginCredentials(requestDTO);

            if (loginResponseDTO != null)
            {
                if (loginResponseDTO.Authorized)
                {
                    return View(); // homepage
                }
            }
            return View(); // unauthorized
        }

        public IActionResult Register()
        {
            return View();
        }

        public AccountResponseDTO RegisterAccount
    }
}