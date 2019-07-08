using Manga.Application.Services;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manga.Infrastructure.IdentityAuthentication
{
    sealed class RegisterUser : IRegisterUserService
    {
        private readonly UserManager<IdentityUser> userManager;

        public Task<Guid> Execute(string username, string password)
        {
            return RegistrationAsync(username, password);
        }

        private async Task<Guid> RegistrationAsync(string username, string password)
        {
            var user = new IdentityUser { UserName = username };
            var result = await userManager.CreateAsync(user, password);

            if (result.Succeeded)
            {
                return new Guid(user.Id);
            }

            return new Guid();

        }
    }
}
