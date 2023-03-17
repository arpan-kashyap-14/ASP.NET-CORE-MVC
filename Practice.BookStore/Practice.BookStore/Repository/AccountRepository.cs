using Microsoft.AspNetCore.Identity;
using Practice.BookStore.Models;
using System.Threading.Tasks;

namespace Practice.BookStore.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly UserManager<IdentityUser> _userManager;

        public AccountRepository(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IdentityResult> CreateUserAsync(SignUpUserModel signUpUserModel)
        {
            var user = new IdentityUser()
            {
                Email = signUpUserModel.Email,
                UserName = signUpUserModel.Email,

            };
          var result= await _userManager.CreateAsync(user, signUpUserModel.Password);
          return result;
        }
    }
}
