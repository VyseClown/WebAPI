using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class ProdutosColetaRepositorio
    {
        public int id { get; set; }
        public int idColeta { get; set; }
        public int idProduto { get; set; }
        public string NomeProduto { get; set; }
        public decimal PrecoProduto { get; set; }
        public string Status { get; set; }
        public List<ProdutosRepositorio> listar(int idLista)
        {
            List<ProdutosRepositorio> lista = null;
            using (dbAppEntities db = new dbAppEntities())
            {
                lista = (from p in db.Produtos
                    join m in db.Marcas on p.idMarca equals m.id
                    join s in db.Setores on p.idSetor equals s.id
                    join lp in db.ProdutosLista on p.id equals lp.id
                    where lp.idLista == idLista
                    //orderby p.Nome
                    select new ProdutosRepositorio()
                    {
                        Id = p.id,
                        Nome = p.Nome,
                        Marca = m.Nome,
                        Codigobarras = p.CodigoBarras,
                        Setor = s.Nome,
                    }).ToList();
            }
            return lista;
        }
        //public void inserir(Produtos pro, int idLista)
        //{C:\Users\alessandrogentil\Documents\Visual Studio 2017\Projects\WebAPI\WebAPI\Controllers\ColetasController.cs
        //    using (dbColetaEntities db =
        //        new dbColetaEntities())
        //    {
        //        Produtos prod = new Produtos();
        //        ProdutosLista prodlista = new ProdutosLista();
        //        prod.Nome = pro.Nome;
        //        prod.CodigoBarras = pro.CodigoBarras;
        //        prod.idMarca = pro.idMarca;
        //        prod.idSetor = pro.idSetor;

        //        db.Produtos.Add(prod);
        //        db.SaveChanges();
        //        prodlista.idLista = idLista;
        //        prodlista.idProduto = prod.id;
        //        db.ProdutosLista.Add(prodlista);
        //        db.SaveChanges();


        //    }
        //}
    }
}
