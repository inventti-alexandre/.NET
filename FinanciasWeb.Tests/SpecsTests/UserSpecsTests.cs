using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinanciasWeb.Domain.Entitys;
using FinanciasWeb.Domain.Dto;
using System.Collections.Generic;
using FinanciasWeb.SharedKernel.Helper;
using FinanciasWeb.Domain.Specs;

namespace FinanciasWeb.Tests.SpecsTests
{
    [TestClass]
    public class UserSpecsTests
    {
        private List<UserDto> _users;

        public UserSpecsTests()
        {
            this._users = new List<UserDto>();
            _users.Add(new UserDto("tiago", StringHelper.Encrypt("12345")));
        }
        [TestMethod]
        [TestCategory("User Specs - Authenticate")]
        public void ShouldAuthenticate() //Ele deve autenticar
        {
            var exp  = UserSpecs.ActivationUser("12345","tiago");
           // var user = _users.AsQueryable().Where(exp).FirstOrDefault();

           // Assert.AreEqual(null, user); // Assert.AreQual = Assegure-se de que não seja (nulo, para o valor retornado); 
        }
    }
}
