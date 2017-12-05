using FinanciasWeb.Domain.Dto;
using FinanciasWeb.Domain.Entitys;
using FinanciasWeb.Domain.Repositories;
using FinanciasWeb.Domain.Service;
using FinanciasWeb.Infra.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanciasWeb.AplicationService.ServicesClass
{
    public class UserAplicationService : AplicationService, IUserAplicationService
    {
        private IUserRepository _repository;

        public UserAplicationService(
            IUserRepository repository,
            IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
            this._repository = repository;

        }

        public User Autentication(string password, string logon)
        {
            return _repository.Autentication(password, logon);
        }

        public User Register(UserDto userdto)
        {
            var user = new User(userdto.Logon, userdto.Password, userdto.Email);
            user.Register();
            _repository.Register(user);

            if (Commit())
                return user;

            return null;
        }
    }
}
