using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Dal;

namespace Dto
{
   public class LocationDto
    {
        public int IdLocation { get; set; }
        public double X { get; set; }

        public double Y { get; set; }
        public Location DtoTODal()
        {
            var config = new MapperConfiguration(cfg =>

                   cfg.CreateMap<LocationDto, Location>()
               );
            var mapper = new Mapper(config);
            return mapper.Map<Location>(this);
        }
        public static LocationDto DalToDto(Location a)
        {
            var config = new MapperConfiguration(cfg =>
                 cfg.CreateMap<Location, LocationDto>()
             );
            var mapper = new Mapper(config);
            return mapper.Map<LocationDto>(a);
        }
    }
}
