using System;
using System.Collections.Generic;
using System.Text;

namespace Manga.Application.Boundaries.Register
{
    public class ServiceOutput
    {
        public Guid CustomerId { get; set; }
        public string Token { get; set; }
    }
}
