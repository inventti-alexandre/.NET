using FinanciasWeb.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanciasWeb.Domain.Repositories
{
    public interface IUserRepository
    {
        List<User> GET();
        List<User> GET(int Id);
        void Register(User user);
        void Created(User user);
        void Delete(User user);
        void Update(User user);
        User Autentication(string password, string logon);
        User GetByEmail(string email);

    }
}
