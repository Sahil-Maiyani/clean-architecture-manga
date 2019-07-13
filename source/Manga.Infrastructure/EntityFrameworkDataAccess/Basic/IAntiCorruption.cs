using Manga.Domain.Customers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Manga.Infrastructure.EntityFrameworkDataAccess.Basic
{
    public interface IAntiCorruption
    {
        Customer Translate(ApplicationUser applicationUser);
    }
}
