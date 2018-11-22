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
        //[HttpPost]
        //[AcceptVerbs("POST")]
        //public void inserir(ColetasModel col, List<ProdutosColeta> prod)
        //{
        //    Coleta cole =
        //        AutoMapper.Mapper.Map<ColetasModel, Coleta>(col);
        //    (new ColetasRepositorio()).inserir(cole,prod);

        //}
        [HttpPost]
        [AcceptVerbs("POST")]
        public void inserir(List<ProdutosAppModel> prod)
        {
            //Coleta cole = AutoMapper.Mapper.Map<ColetasModel, Coleta>(col);
            //(new ColetasRepositorio()).inserir(cole, prod);
            ProdutosAppModel produto = new ProdutosAppModel();
            ProdutosColeta listaProdutos = new ProdutosColeta();
            produto = prod.First();
            new Coleta {
                idMercado = produto.MercadoID,
                idTipoLista = 1,
                Data = produto.Data,

            };
            foreach (ProdutosAppModel item in prod)
            {
                new ProdutosColeta
                {
                    idProduto = produto.Pid,
                    PrecoProduto = produto.Preco,//no metodo de inserir vamos ter que colocar o id da coleta em cada produto
                };
            }
            
            //(new ColetasRepositorio).inserir()

        }

    }
}
