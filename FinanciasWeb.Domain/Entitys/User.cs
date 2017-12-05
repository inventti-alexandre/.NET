using FinanciasWeb.SharedKernel.Helper;
using FinanciasWeb.Domain.Scopes;

namespace FinanciasWeb.Domain.Entitys
{
    public class User
    {
        public User(string logon, string password, string email)
        {
            this.Name = Name;
            this.Email = email;
            this.Logon = logon;
            this.Password = StringHelper.Encrypt(password);
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Logon { get; set; }
        public string Password { get; set; }

        public void Register()
        {
            this.RegisterUserScopesIsValid();
        }
    }
}
