using FinanciasWeb.SharedKernel.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanciasWeb.Domain.Dto
{
    public class UserDto
    {
        public UserDto(string logon, string password, string email, string name)
        {
            this.Email = email;
            this.Logon = logon;
            this.Name  = name;
            this.Password = StringHelper.Encrypt(password);
        }

        public UserDto(string logon, string password)
        {
            // TODO: Complete member initialization
            this.Logon = logon;
            this.Password = password;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Logon { get; set; }
        public string Password { get; set; }
    }
}
