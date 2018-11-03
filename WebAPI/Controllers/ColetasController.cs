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
    public class ColetasController : ApiController
    {
        [HttpPost]
        [AcceptVerbs("POST")]
        public void inserir(ColetasModel col, List<ProdutosColeta> prod)
        {
            Coleta cole =
                AutoMapper.Mapper.Map<ColetasModel, Coleta>(col);
            (new ColetasRepositorio()).inserir(cole,prod);

        }
        
    }
}
