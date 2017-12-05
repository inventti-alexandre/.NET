using FinanciasWeb.Domain.Dto;
using FinanciasWeb.Domain.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace financiasweb.Api.Controllers
{
    public class UserController : BaseController
    {
        private readonly IUserAplicationService _service;

        public UserController(IUserAplicationService service)
        {
            this._service = service;
        }

        [HttpPost]
        [Route("api/users")]
        public Task<HttpResponseMessage> Post([FromBody]dynamic body)
        {
            var UserDto = new UserDto
                (
                    email : (string)body.email,
                    logon : (string)body.logon,
                    name  : (string)body.name,
                    password : (string)body.password

               ); 

            var User = _service.Register(UserDto);

            return CreateResponse(HttpStatusCode.Created, User);
        }
    }
}