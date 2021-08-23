﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingCenterCRM.Models.Account;

namespace TrainingCenterCRM.Controllers
{
    public class AccountsController : Controller
    {

        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        private readonly ILogger logger;

        public AccountsController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, RoleManager<IdentityRole> roleManager, ILogger logger)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            this.logger = logger;
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var user = new IdentityUser { Email = model.Email, UserName = model.Email };

                    var result = await _userManager.CreateAsync(user, model.Password);
                    if (result.Succeeded)
                    {
                        if (await _roleManager.RoleExistsAsync("user"))
                            await _userManager.AddToRoleAsync(user, "user");

                        await _signInManager.SignInAsync(user, false);
                        return RedirectToAction("Index", "Students");
                    }
                    else
                    {
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError(string.Empty, error.Description);
                        }
                    }
                }
                return View(model);
            }
            catch (Exception ex)
            {
                logger.LogError(ex.ToString());
                return StatusCode(500);
            }
        }
        [HttpGet]
        public IActionResult Login(string returnUrl = null)
        {
            return View(new LoginModel() { ReturnUrl = returnUrl });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model)
        {   
            try
            {
                if (ModelState.IsValid)
                {
                    var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, true, false);
                    if (result.Succeeded)
                    {
                        if (!string.IsNullOrEmpty(model.ReturnUrl) && Url.IsLocalUrl(model.ReturnUrl))
                        {
                            return Redirect(model.ReturnUrl);
                        }
                        else
                        {
                            return RedirectToAction("Index", "Students");
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("", "Incorrect email or password");
                    }
                }
                return View(model);
            }
            catch (Exception ex) 
            { 
                logger.LogError(ex.ToString()); 
                return StatusCode(500); 
            }
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {   try
            {
                await _signInManager.SignOutAsync();
                return RedirectToAction("Index", "Students");
            }
            catch (Exception ex) 
            { 
                logger.LogError(ex.ToString()); 
                return StatusCode(500);
            }
        }
        public IActionResult RecoveryPassword()
        {
            return View();
        }
    }
}
