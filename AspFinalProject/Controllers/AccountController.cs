﻿using AspFinalProject.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AspFinalProject.Controllers
{
    
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(AccountRegisterViewModel viewModel)
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(AccountLoginViewModel viewModel)
        {
            return View();
        }

        public IActionResult Logout()
        {
            return View();
        }
    }
}