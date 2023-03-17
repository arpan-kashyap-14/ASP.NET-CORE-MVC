
using Microsoft.AspNetCore.Identity;
using Practice.BookStore.Models;
using System.Threading.Tasks;

namespace Practice.BookStore.Repository
{
    public interface IAccountRepository
    {
        Task<IdentityResult> CreateUserAsync(SignUpUserModel signUpUserModel);
    }
}