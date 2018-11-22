using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class ProdutosAppModel
    {
        public string Codigobarras { get; set; }
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Nome { get; set; }
        public int ColetaID { get; set; }
        public DateTime Data { get; set; }
        public int MercadoID { get; set; }
        public int Pid { get; set; }
        public decimal Preco { get; set; }
        public int idItem { get; set; }
    }
}