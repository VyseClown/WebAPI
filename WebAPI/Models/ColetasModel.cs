using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class ColetasModel
    {
        public int id { get; set; }
        public int idMercado { get; set; }
        //public string NomeMercado { get; set; }
        public int idTipoLista { get; set; }
        //public string nomeLista { get; set; }
        public DateTime Data { get; set; }
        public string ResponsavelColeta { get; set; }
        public string ResponsavelMercado { get; set; }
        public string ImgAssinatura { get; set; }
    }
}