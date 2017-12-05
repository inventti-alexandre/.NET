using FinanciasWeb.Domain.Dto;
using FinanciasWeb.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanciasWeb.Domain.Service
{
    public interface IUserAplicationService
    {
        User Autentication(string password, string logon);
        User Register(UserDto userdto);

    }
}
