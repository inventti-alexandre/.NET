using FinanciasWeb.Domain.Entitys;
using FinanciasWeb.SharedKernel.Validation.DomainNotificationHelper.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanciasWeb.Domain.Scopes
{
    public static class UserScopes
    {
        public static bool RegisterUserScopesIsValid(this User user)
        {
            return Validation.IsSatisfiedBy
                (
                    Validation.AssertNotEmpty(user.Email, "Email é Obrigatorio"),
                    Validation.AssertNotEmpty(user.Logon, "Logon é Obrigatorio"),
                    Validation.AssertNotEmpty(user.Password, "Senha é Obrigatoria")     
                );
        }

        public static bool AuthenticateUserScopesIsValid(this User user, string Email, string EncryptedPassword)
        {
            return Validation.IsSatisfiedBy
                (
                    Validation.AssertEmailIsValid(Email, ""),
                    Validation.AssertAreEquals(EncryptedPassword, user.Password, "Senhas devem ser Iguais")                    
                );
        }
    }
}
