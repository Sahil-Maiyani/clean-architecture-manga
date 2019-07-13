using Manga.Application.Boundaries.Register;
using Manga.Application.Boundaries.Register.Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manga.Application.Services
{
    public interface IRegisterUserService
    {
        ServiceOutput Execute(ServiceInput input);
    }
}
