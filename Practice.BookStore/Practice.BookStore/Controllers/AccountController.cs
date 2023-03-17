using Microsoft.AspNetCore.Mvc;
using Practice.BookStore.Models;
using Practice.BookStore.Repository;
using System.Threading.Tasks;

namespace Practice.BookStore.Controllers
{
    public class AccountController : Controller
    {
        private readonly AccountRepository _accountRepository;

        public AccountController(AccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }



        [Route("signup")]
        public IActionResult Signup()
        {
            return View();
        }

       
        [Route("signup")]
        [HttpPost]
        public async Task<IActionResult> Signup(SignUpUserModel signUpUserModel)
        {
            if(ModelState.IsValid)
            {
                var result =await _accountRepository.CreateUserAsync(signUpUserModel);
                if(!result.Succeeded)
                {
                    foreach(var errorMessage in result.Errors)
                    {
                        ModelState.AddModelError("", errorMessage.Description);
                    }
                    return View(signUpUserModel);
                }

                ModelState.Clear();
            }
            return View();
        }
    }
}
