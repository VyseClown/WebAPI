using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class MercadosRepositorio
    {
        public int id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public List<MercadosRepositorio> listar()
        {
            List<MercadosRepositorio> lista = null;
            using (dbColetaEntities db = new dbColetaEntities())
            {
                lista = (from p in db.Mercados
                    //orderby p.Nome
                    select new MercadosRepositorio()
                    {
                        Nome = p.Nome,
                        id = p.id,

                        Telefone = p.Telefone
                    }).ToList();
            }
            return lista;
        }
        public MercadosRepositorio GetProduto(int codigo)
        {
            MercadosRepositorio pro = null;
            using (dbColetaEntities db =
                new dbColetaEntities())
            {
                pro = (from p in db.Mercados
                    where p.id == codigo
                    select new MercadosRepositorio()
                    {
                        Nome = p.Nome,
                        id = p.id,
                        Telefone = p.Telefone
                    }).FirstOrDefault();
            }
            return pro;
        }
        public void inserir(Mercados mer)
        {
            using (dbColetaEntities db =
                new dbColetaEntities())
            {
                db.Mercados.Add(mer);
                db.SaveChanges();

            }
        }
    }
}
