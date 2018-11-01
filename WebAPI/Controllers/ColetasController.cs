using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Repositorio;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class ColetasController : ApiController
    {
        [HttpPost]
        [AcceptVerbs("POST")]
        public void inserir(ColetasModel col, List<ProdutosColeta> prod, int idLista)
        {
            Coleta cole =
                AutoMapper.Mapper.Map<ColetasModel, Coleta>(col);
            (new ColetasRepositorio()).inserir(cole,prod,idLista);

        }
        
    }
}
