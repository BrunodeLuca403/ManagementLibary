using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Infrastructure.Auth
{
    public interface IAuthService
    {
        string ComputeHash(string Password);

        string GenerateToken(string email, string role);    
    }
}
