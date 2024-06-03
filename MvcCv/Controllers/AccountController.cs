
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MvcCv.DTO.DTOs.IdentityDtos;
using MvcCv.Entity.Entities;

namespace MvcCv.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        [Authorize(Roles ="Admin")]
        public IActionResult Register()
        {
            return View();
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> Register(RegisterDto registerDto)
        {
            var user = new AppUser
            {
                UserName = registerDto.UserName,
                Email = registerDto.Email
            };
            var result = await _userManager.CreateAsync(user,registerDto.Password);

            if (!result.Succeeded)
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
                return View();
            }
            return RedirectToAction("Login");
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(loginDto.UserName, loginDto.Password, false , true);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "About", new { area = "Admin" });
                }
            }
            ModelState.AddModelError("", "Kullanıcı adı veya şifre hatalı");
            return View();
            //var user = await _userManager.FindByNameAsync(loginDto.UserName);
            //if (user == null)
            //{
            //    ModelState.AddModelError("", "Kullanıcı adı veya şifre hatalı");
            //    return View();
            //}
            //var result = await _signInManager.CheckPasswordSignInAsync(user, loginDto.Password, false);
            //if (!result.Succeeded)
            //{
            //    ModelState.AddModelError("", "Kullanıcı adı veya şifre hatalı");
            //    return View();
            //}

            //return RedirectToAction("Index", "About", new { area = "Admin" });
        }
    }
}
