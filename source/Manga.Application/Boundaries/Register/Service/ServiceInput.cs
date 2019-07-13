using System;
using System.Collections.Generic;
using System.Text;

namespace Manga.Application.Boundaries.Register.Service
{
    public class ServiceInput
    {
        public string SSN { get; set; }
        public string Name { get; set; }

        public string Password { get; set; }
    }
}
