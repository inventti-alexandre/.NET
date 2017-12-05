using FinanciasWeb.Domain.Entitys;
using FinanciasWeb.Domain.Repositories;
using FinanciasWeb.Domain.Specs;
using FinanciasWeb.Infra.Persistence.DataContexts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FinanciasWeb.Infra.Repositories
{
    public class UserRepository : IUserRepository
    {
        private StoreDataContext _context;

        public UserRepository(StoreDataContext context)
        {
            _context = context;
        }

        public void Register(User user)
        {
            _context.User.Add(user);
        }
        public User Autentication(string password, string logon)
        {
            return _context.User.Where(UserSpecs.ActivationUser(password, logon)).FirstOrDefault();
        }

        public void Created(User user)
        {
            throw new NotImplementedException();
        }

        public void Delete(User user)
        {
            throw new NotImplementedException();
        }

        public List<User> GET()
        {
            throw new NotImplementedException();
        }

        public List<User> GET(int Id)
        {
            throw new NotImplementedException();
        }

        public User GetByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public void Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
