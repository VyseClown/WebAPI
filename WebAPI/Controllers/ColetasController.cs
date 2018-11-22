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
            ColetasRepositorio colrep = new ColetasRepositorio();
            ProdutosAppModel produto = new ProdutosAppModel();
            List<ProdutosColeta> listaProdutos = new List<ProdutosColeta>();
            produto = prod.First();
            Coleta col = new Coleta {
                idMercado = produto.MercadoID,
                idTipoLista = 1,
                Data = produto.Data,

            };
            foreach (ProdutosAppModel item in prod)
            {
                ProdutosColeta produ = new ProdutosColeta
                {
                    idProduto = produto.Pid,
                    PrecoProduto = produto.Preco,//no metodo de inserir vamos ter que colocar o id da coleta em cada produto
                    
                };
                listaProdutos.Add(produ);
            }

            colrep.inserirApp(col, listaProdutos);
            //(new ColetasRepositorio).inserir()

        }
        [HttpPost]
        [AcceptVerbs("POST")]
        public string UploadCustomerImage()
        {
            string mensagem = "oi";
            return mensagem;


        }

    }
}
