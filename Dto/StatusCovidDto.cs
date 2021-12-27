using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Dal;

namespace Dto
{
   public class StatusCovidDto
    {
        public int CodeStatus { get; set; }
        public string DecriptionStatus { get; set; }

       





        public StatusCovid19 DtoTODal()
        {
            var config = new MapperConfiguration(cfg =>

                   cfg.CreateMap<StatusCovidDto, StatusCovid19>()
               );
            var mapper = new Mapper(config);
            return mapper.Map<StatusCovid19>(this);
        }
        public static StatusCovidDto
            DalToDto(StatusCovid19 a)
        {
            var config = new MapperConfiguration(cfg =>
                 cfg.CreateMap<StatusCovid19, StatusCovidDto>()
             );
            var mapper = new Mapper(config);
            return mapper.Map<StatusCovidDto>(a);
        }
    }
}
