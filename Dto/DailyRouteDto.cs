using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using AutoMapper;

namespace Dto
{
   public class DailyRouteDto
    {
        public DateTime DateO { get; set; }
        public int IdMishmeret { get; set; }
        public int IdDoctor { get; set; }
        public int NumberOfPatients { get; set; }
        public int CurrentIndex { get; set; }








        public DailyRoute DtoTODal()
        {
            var config = new MapperConfiguration(cfg =>

                   cfg.CreateMap<DailyRouteDto, DailyRoute>()
               );
            var mapper = new Mapper(config);
            return mapper.Map<DailyRoute>(this);
        }
        public static DailyRouteDto
            DalToDto(DailyRoute a)
        {
            var config = new MapperConfiguration(cfg =>
                 cfg.CreateMap<DailyRoute, DailyRouteDto>()
             );
            var mapper = new Mapper(config);
            return mapper.Map<DailyRouteDto>(a);
        }
    }
}
