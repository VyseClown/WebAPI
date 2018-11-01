using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;

namespace WebAPI.Mappers
{
    public class AutoMapperInitialize
    {
        public static void MaperConfig()
        {
            // Configurando o AutoMapper para registrar os profiles
            Mapper.Initialize(c => c.AddProfile<AutoMapperConfig>());
        }
    }
}