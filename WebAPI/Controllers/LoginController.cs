using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Repositorio;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class LoginController : ApiController
    {
        [HttpGet]
        [AcceptVerbs("GET")]
        public Login logar(LoginModel login)
        {
            Login log =
                AutoMapper.Mapper.Map<LoginModel, Login>(login);
            (new LoginRepositorio()).logar(login.login, login.senha);
            return log;
        }
    }
}
