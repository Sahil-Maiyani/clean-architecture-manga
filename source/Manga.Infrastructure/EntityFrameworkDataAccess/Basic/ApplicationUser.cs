using Manga.Domain.ValueObjects;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Manga.Infrastructure.EntityFrameworkDataAccess.Basic
{
    public class ApplicationUser: IdentityUser
    {
        public SSN SSN { get; set; }
    }
}
