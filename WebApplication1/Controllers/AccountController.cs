using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StudentenMaaltijd.Entity.Entity;
using StudentenMaaltijd.Entity.Entity.Identity;
using StudentenMaaltijd.Entity.Repository;

namespace StudentenMaaltijd.Web.Controllers
{
    public class AccountController : Controller
    { 
        private UserManager<IdentityUser> userManager;
        private SignInManager<IdentityUser> signInManager;
        private IStudentRepository studentRepository;

        public AccountController(UserManager<IdentityUser> userMgr,
            SignInManager<IdentityUser> signInMgr, IStudentRepository studentRepo)
        {
            userManager = userMgr;
            signInManager = signInMgr;
            studentRepository = studentRepo;

        }



        public ActionResult Register()
        {
            return View("Register");
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                IdentityUser user = await userManager.FindByIdAsync(model.Name);
                if (user == null)
                {
                    user = new IdentityUser(model.Email);
                    var result = await userManager.CreateAsync(user, model.Password);
                    if (result.Succeeded)
                    {
                        var student = new Student { StudentName = model.Name, Email = model.Email, PhoneNumber = model.PhoneNumber };
                        studentRepository.AddStudent(student);
                        await signInManager.SignInAsync(user, isPersistent: false);
                        return RedirectToAction("Index", "Home");
                    }
                }
            }

            // If we got this far, something failed, redisplay form   
            return View("Register", model);
        }

        [AllowAnonymous]
        public ViewResult Login()
        {
            return View("Login");
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel loginModel)
        {
            if (ModelState.IsValid)
            {
                IdentityUser user =
                    await userManager.FindByNameAsync(loginModel.Email);
                if (user != null)
                {
                    await signInManager.SignOutAsync();
                    if ((await signInManager.PasswordSignInAsync(user,
                        loginModel.Password, false, false)).Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
            }
            ModelState.AddModelError("", "Invalid name or password");
            return View(loginModel);
        }
        public async Task<RedirectResult> Logout(string returnUrl = "/")
        {
            await signInManager.SignOutAsync();
            return Redirect(returnUrl);
        }
    }
}