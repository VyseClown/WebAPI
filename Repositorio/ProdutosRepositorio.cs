using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Repositorio
{
    public class ProdutosRepositorio
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Marca { get; set; }
        public string Codigobarras { get; set; }
        public string Setor { get; set; }
        public List<ProdutosRepositorio> listar()
        {
            List<ProdutosRepositorio> lista = null;
            using (dbColetaEntities db = new dbColetaEntities())
            {
                lista = (from p in db.Produtos
                    join m in db.Marcas on p.idMarca equals m.id
                    join s in db.Setores on p.idSetor equals s.id
                         //orderby p.Nome
                    select new ProdutosRepositorio()
                    {
                        Nome = p.Nome,
                        Marca = m.Nome,
                        Codigobarras = p.CodigoBarras,
                        Setor = s.Nome,
                    }).ToList();
            }
            return lista;
        }
        public List<ProdutosRepositorio> ListarTipoLista(int idTipoLista)
        {
            List<ProdutosRepositorio> lista = null;
            using (dbColetaEntities db = new dbColetaEntities())
            {
                lista = (from pl in db.ProdutosLista
                    join p in db.Produtos on pl.idProduto equals p.id
                    join m in db.Marcas on p.idMarca equals m.id
                    join s in db.Setores on p.idSetor equals s.id
                         //join l in db.ProdutosLista on p.id equals l.idProduto
                    where pl.idLista == idTipoLista 
                    select new ProdutosRepositorio()
                    {
                        Nome = p.Nome,
                        Marca = m.Nome,
                        Codigobarras = p.CodigoBarras,
                        Setor = s.Nome,
                    }).ToList();
            }
            return lista;
        }
        public ProdutosRepositorio GetProduto(int codigo)
        {
            ProdutosRepositorio pro = null;
            using (dbColetaEntities db =
                new dbColetaEntities())
            {
                pro = (from p in db.Produtos
                    where p.id == codigo
                    join m in db.Marcas on p.idMarca equals m.id
                    join s in db.Setores on p.idSetor equals s.id
                       select new ProdutosRepositorio()
                    {
                        Nome = p.Nome,
                        Marca = m.Nome,
                        Codigobarras = p.CodigoBarras,
                        Setor = s.Nome,
                    }).FirstOrDefault();
            }
            return pro;
        }
        public ProdutosRepositorio GetProdutoBarras(string codigodebarras)
        {
            ProdutosRepositorio pro = null;
            using (dbColetaEntities db =
                new dbColetaEntities())
            {
                pro = (from p in db.Produtos
                       where p.CodigoBarras == codigodebarras
                       join m in db.Marcas on p.idMarca equals m.id
                       join s in db.Setores on p.idSetor equals s.id
                       select new ProdutosRepositorio()
                       {
                           Nome = p.Nome,
                           Marca = m.Nome,
                           Codigobarras = p.CodigoBarras,
                           Setor = s.Nome,
                       }).FirstOrDefault();
            }
            return pro;
        }
        public int GetMarcaID(string nome)
        {
            int pro;
            using (dbColetaEntities db =
                new dbColetaEntities())
            {
                pro = (from p in db.Marcas
                    where p.Nome == nome
                    select p.id).FirstOrDefault();
            }
            return pro;
        }
        public int GetSetorID(string nome)
        {
            int pro;
            using (dbColetaEntities db =
                new dbColetaEntities())
            {
                pro = (from p in db.Setores
                    where p.Nome == nome
                    select p.id).FirstOrDefault();
            }
            return pro;
        }
        public void inserir(Produtos pro, List<int> idLista)//adicionar quais tipos de lista o produto vai entrar !
        {
            using (dbColetaEntities db =
                new dbColetaEntities())
            {
                Produtos prod = new Produtos();
                ProdutosLista prodlista = new ProdutosLista();
                prod.Nome = pro.Nome;
                prod.CodigoBarras = pro.CodigoBarras;
                prod.idMarca = pro.idMarca;//(new ProdutosRepositorio().GetMarcaID(pro.Marca));
                prod.idSetor = pro.idSetor;//(new ProdutosRepositorio().GetSetorID(pro.Setor));

                db.Produtos.Add(prod);
                db.SaveChanges();
                foreach (int i in idLista)
                {
                    prodlista.idLista = idLista[i];
                    prodlista.idProduto = prod.id;
                    db.ProdutosLista.Add(prodlista);
                    db.SaveChanges();
                }
                
            }
        }
    }

}
