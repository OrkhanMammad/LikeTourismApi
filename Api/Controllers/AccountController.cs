﻿using DomainLayer.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTOs.AppUser;
using ServiceLayer.Services.Interfaces;
using System;
using System.Threading.Tasks;


namespace Api.Controllers
{
    public class AccountController : BaseController
    {
        private readonly IAccountService _service;
        private readonly IWebHostEnvironment _env;
        private readonly UserManager<AppUser> _userManager;
        private readonly IEmailService _emailService;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AccountController(IAccountService service, IWebHostEnvironment env, UserManager<AppUser> userManager, IEmailService emailService, RoleManager<IdentityRole> roleManager)
        {
            _service = service;
            _env = env;
            _userManager = userManager;
            _emailService = emailService;
            _roleManager = roleManager;

        }

        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterDto registerDto)
        {
            await _service.Register(registerDto);
            AppUser appUser = await _userManager.FindByEmailAsync(registerDto.Email);
            var code = await _userManager.GenerateEmailConfirmationTokenAsync(appUser);
            var link = Url.Action(nameof(ConfirmEmail), "Account", new { userId = appUser.Id, token = code }, Request.Scheme, Request.Host.ToString());
            _emailService.Register(registerDto, link);
            return Ok();
        }

        [HttpGet]
        [Route("ConfirmEmail")]
        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            await _service.ConfirmEmail(userId, token);
            return Redirect("http://localhost:3000/login");
        }

        [HttpPost]
        [Route("Login")]
        public async Task<string> Login([FromBody] LoginDto loginDto)
        {
            return await _service.Login(loginDto);
        }
        [HttpGet]
        [Route("GetUserByEmail/{email}")]
        public async Task<UserDto> GetUserByEmail([FromRoute] string email)
        {
            var user = await _service.GetUserByEmailAsync(email);

            return user;
        }

        [HttpPost]
        [Route("ForgotPassword")]
        public async Task<IActionResult> ForgotPassword([FromBody] ForgotPasswordDto forgotPassword)
        {
            var user = await _userManager.FindByEmailAsync(forgotPassword.Email);

            if (user is null) throw new ArgumentNullException();

            string forgotpasswordtoken = await _userManager.GeneratePasswordResetTokenAsync(user);
            //string url = Url.Action("http://localhost:3000/", "forgotpassword", new { email = user.Email, Id = user.Id, token = forgotpasswordtoken, }, Request.Scheme);
            string url2 = "http://localhost:3000/ResetPassword/" + user.Email + "/token=" + forgotpasswordtoken;
            _emailService.ForgotPassword(user, url2, forgotPassword);

            return Ok();
        }

        [HttpPost]
        [Route("ResetPassword")]
        public async Task<IActionResult> ResetPassword(ResetPasswordDto resetPassworddto)
        {


            var user = await _userManager.FindByEmailAsync(resetPassworddto.Email);

            if (user is null) return NotFound();

            IdentityResult result = await _userManager.ResetPasswordAsync(user, resetPassworddto.Token, resetPassworddto.Password);

            return Ok();

        }

        [HttpPut]
        [Route("UpdateUserPassword/{email}")]
        public async Task<IActionResult> UpdatePassword([FromRoute] string email, [FromBody] UpdatePasswordDto updatePasswordDto)
        {
            AppUser appUser = await _userManager.FindByEmailAsync(email);
            await _service.UpdatePassword(appUser, updatePasswordDto);
            return Ok();
        }


        //[HttpPost]
        //[Route("Role")]
        //public async Task CreateRole()
        //{
        //    foreach (var role in Enum.GetValues(typeof(UserRoless)))
        //    {
        //        if (!await _roleManager.RoleExistsAsync(role.ToString()))
        //        {
        //            await _roleManager.CreateAsync(new IdentityRole { Name = role.ToString() });
        //        }
        //    }
        //}
    }
}
