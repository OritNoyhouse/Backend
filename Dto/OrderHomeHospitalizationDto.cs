using AutoMapper;
using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
  public  class OrderHomeHospitalizationDto
    {
        public int IdOrder { get; set; }
        public int IdPatient { get; set; }
        public int IdDoctor { get; set; }
        public DateTime DateOf { get; set; }
        public int HourOfVisit { get; set; }
        public int LevelOfUrgent { get; set; }
      

        public int LevelUrgent { get; set; }
        public OrderHomeHospitalization DtoTODal()
        {
            var config = new MapperConfiguration(cfg =>

                   cfg.CreateMap<OrderHomeHospitalizationDto, OrderHomeHospitalization>()
               );
            var mapper = new Mapper(config);
            return mapper.Map<OrderHomeHospitalization>(this);
        }
        public static OrderHomeHospitalizationDto DalToDto(OrderHomeHospitalization a)
        {
            var config = new MapperConfiguration(cfg =>
                 cfg.CreateMap<OrderHomeHospitalization, OrderHomeHospitalizationDto>()
             );
            var mapper = new Mapper(config);
            return mapper.Map<OrderHomeHospitalizationDto>(a);
        }
    }
}
