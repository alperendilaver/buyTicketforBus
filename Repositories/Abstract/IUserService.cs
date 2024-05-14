using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using buyticketforbus.Data;
using buyticketforbus.Models.UserViewModels;
using Microsoft.AspNetCore.Identity;

namespace buyticketforbus.Repositories.Abstract
{
    public interface IUserService
    {   
        Task<AppUser> GetUserById(string id);
        Task<AppUser> GetUserByEmail(string email);

        Task<SignInResult> Login(LoginViewModel model);
        Task<IdentityResult> Register(RegisterViewModel registerViewModel);

        Task<EmailConfirmViewModel> GenerateEmailConfirmationToken(string email);
        Task<PasswordResetMail> GeneratePasswordResetToken(string Email);
        
        Task<IdentityResult> ResetPassword(string Id,string token,string newPassword);

        Task<IdentityResult> ConfirmEmail(string userId,string token);

        public void DeleteAccount();

    }
}