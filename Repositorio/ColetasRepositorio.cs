using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class ColetasRepositorio
    {
        public int id { get; set; }
        public int idMercado { get; set; }
        public string NomeMercado { get; set; }
        public int idTipoLista { get; set; }
        public string nomeLista { get; set; }
        public DateTime Data { get; set; }
        public string ResponsavelColeta { get; set; }
        public string ResponsavelMercado { get; set; }
        public string ImgAssinatura { get; set; }//brandão, me deixa tentar fazer a parte do plugin de codigo de barras que deve ser mais fácil

        public void inserir(Coleta col, List<ProdutosColeta> pro)
        {
            using (dbAppEntities db =
                new dbAppEntities())
            {
                Produtos prod = new Produtos();
                ProdutosColeta prodlista = new ProdutosColeta();

                db.Coleta.Add(col);
                db.SaveChanges();
                foreach (ProdutosColeta i in pro)
                {
                    //prodlista.idColeta = col.id;
                    //prodlista.idProduto = i.id;
                    //prodlista.PrecoProduto = i.PrecoProduto;
                    //prodlista.Status = i.Status;
                    db.ProdutosColeta.Add(i);
                    db.SaveChanges();
                }

            }
        }
        public List<MercadosRepositorio> listar()
        {
            List<MercadosRepositorio> lista = null;
            using (dbAppEntities db = new dbAppEntities())
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
    }
}
