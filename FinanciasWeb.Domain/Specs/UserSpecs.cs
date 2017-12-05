using FinanciasWeb.Domain.Entitys;
using FinanciasWeb.SharedKernel.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FinanciasWeb.Domain.Specs
{
    public class UserSpecs
    {
        public static Expression<Func<User, bool>> ActivationUser(string password, string Logon)
        {
            string encriptedPassword = StringHelper.Encrypt(password);
            return x => x.Password == encriptedPassword && x.Logon == Logon;
        }

        public static Expression<Func<User, bool>> GetByEmail(string Email)
        {
            return x => x.Email == Email;
        }
    }
}
