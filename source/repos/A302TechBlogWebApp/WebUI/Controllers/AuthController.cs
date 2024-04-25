using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebUI.DTOs;
using WebUI.Models;

namespace WebUI.Controllers
{
    //DTO-Data Transfer Object
    public class AuthController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        public AuthController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;//class-i her defe new-lamasin deye 1 defe newlayir
            _signInManager = signInManager;
        }//dependecy injextion-arxada her metod,her class ucun yenilenmesin arxada umumen 1 defe new-lansin
     
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterDTO registerDTO)
        {
            if (!ModelState.IsValid)
            {
                return View();//validasiyalar duzgun deyilse sehifeye qaytarsin
            }
            //async kodlar metodlar ardicil oxunur 
            User newUser = new()
            {
                FirstName = registerDTO.FirstName,
                LastName = registerDTO.LastName,
                Email = registerDTO.Email,
                PhotoUrl = "/",
                UserName = registerDTO.Email

            };
            IdentityResult identityResult = await _userManager.CreateAsync(newUser, registerDTO.Password);
            if (identityResult.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                foreach (var error in identityResult.Errors)
                {
                    ModelState.AddModelError("error", error.Description);
                }
                return View();
            }
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginDTO loginDTO) {
            if (!ModelState.IsValid)
            {
                return View(loginDTO);
            }
            var findUser = await _userManager.FindByEmailAsync(loginDTO.Email);
            if (findUser == null) {
                ModelState.AddModelError("error", "User not found!");
                return View();
            }
            Microsoft.AspNetCore.Identity.SignInResult signInResult = await _signInManager.PasswordSignInAsync(findUser, loginDTO.Password, loginDTO.RememberMe, false);
            if (signInResult.Succeeded)
            {
                return RedirectToAction("Index", "Home");

            }
            else
            {
                ModelState.AddModelError("error", "Username or password is wrong!");

                return View();
            }
           
        }
        [Authorize]
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

    }

    
}

