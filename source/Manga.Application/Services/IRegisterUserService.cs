using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manga.Application.Services
{
    public interface IRegisterUserService
    {
        Task<Guid> Execute(string username, string password);
    }
}
