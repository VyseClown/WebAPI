using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class ProdutosColetaModel
    {
        public int id { get; set; }
        public int idColeta { get; set; }
        public int idProduto { get; set; }
        //public string NomeProduto { get; set; }
        public decimal PrecoProduto { get; set; }
        public string Status { get; set; }
    }
}