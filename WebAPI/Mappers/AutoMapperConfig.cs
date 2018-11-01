using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Repositorio;
using WebAPI.Models;

namespace WebAPI.Mappers
{
    public class AutoMapperConfig:Profile
    {
        public static IMapper Mapper { get; private set; }

        public AutoMapperConfig()
        {
            CreateMap<Produtos, ProdutosModel>();
            CreateMap<ProdutosModel, Produtos>();

            CreateMap<Coleta, ColetasModel>();
            CreateMap<ColetasModel, Coleta>();

            CreateMap<Mercados, MercadosModel>();
            CreateMap<MercadosModel, Mercados>();

            CreateMap<ProdutosColeta, ProdutosColetaModel>();
            CreateMap<ProdutosColetaModel, ProdutosColeta>();

            CreateMap<Login, LoginModel>();
            CreateMap<LoginModel, Login>();
        }

      
    }
}