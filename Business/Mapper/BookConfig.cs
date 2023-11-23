using AutoMapper;
using Business.DTO;
using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Mapper
{
    public class BookConfig
    {
        public static void createMap(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<Book, BookDTO>()
                .ForMember(des => des.Author, act => act.MapFrom(src => src.Author));
        }
    }
}
