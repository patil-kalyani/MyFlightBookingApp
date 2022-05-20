using login.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace login.Interfaces
{
    public interface IJWTManagerRepository
    {
        Tokens Authenticate(Users users, bool IsRegister);
    }
}
