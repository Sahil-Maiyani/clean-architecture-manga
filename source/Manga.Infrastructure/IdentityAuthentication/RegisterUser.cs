using Manga.Application.Services;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manga.Infrastructure.IdentityAuthentication
{
    public sealed class RegisterUser : IRegisterUserService
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly IGenerateToken generateToken;

        public RegisterUser(UserManager<IdentityUser> userManager, IGenerateToken generateToken)
        {
            this.userManager = userManager;
            this.generateToken = generateToken;
        }

        public Guid Execute(string username, string password)
        {
            return RegistrationAsync(username, password).Result;
        }

        private async Task<Guid> RegistrationAsync(string username, string password)
        {
            var user = new IdentityUser { UserName = username };
            var result = await userManager.CreateAsync(user, password);

            if (result.Succeeded)
            {
                var debug = await generateToken.GetToken(username, user);
                return new Guid(user.Id);
            }

            return new Guid();

        }
    }
}
