using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using Repositorio;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ProdutosController : ApiController
    {
        // GET: Produtos
        [HttpGet]
        [AcceptVerbs("GET")]
        public List<ProdutosModel> Listar()
        {
            return AutoMapper.Mapper.Map<List<ProdutosRepositorio>,
                    List<ProdutosModel>>
                ((new ProdutosRepositorio()).listar());
        }
        [HttpPost]
        [AcceptVerbs("POST")]
        public void inserir(ProdutosModel model, List<int> idListas)
        {
            
            Produtos pro =
                AutoMapper.Mapper.Map<ProdutosModel, Produtos>(model);
            (new ProdutosRepositorio()).inserir(pro,idListas);

        }

    }
}