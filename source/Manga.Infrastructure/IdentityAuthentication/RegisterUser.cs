using Manga.Application.Boundaries.Register;
using Manga.Application.Boundaries.Register.Service;
using Manga.Application.Services;
using Manga.Infrastructure.EntityFrameworkDataAccess.Basic;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System.Threading.Tasks;

namespace Manga.Infrastructure.IdentityAuthentication
{
    public sealed class RegisterUser : IRegisterUserService
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly IGenerateToken generateToken;
        private ServiceOutput Output { get; set; }

        public RegisterUser(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IGenerateToken generateToken)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.generateToken = generateToken;
        }

        public ServiceOutput Execute(ServiceInput input)
        {
            return RegistrationAsync(input).Result;
        }

        private async Task<ServiceOutput> RegistrationAsync(ServiceInput input)
        {
            var user = new ApplicationUser { UserName = input.Name, SSN = input.SSN };
            var result = await userManager.CreateAsync(user, input.Password);

            if (result.Succeeded)
            {
                await signInManager.SignInAsync(user, isPersistent: false);

                var token = await generateToken.GetToken(user.UserName, user);


                return new ServiceOutput { CustomerId = new Guid(user.Id), Token = token };
            }

            return null;

        }
    }
}
