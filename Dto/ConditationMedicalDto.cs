using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Dal;

namespace Dto
{
  public  class ConditationMedicalDto
    {
        public int IdConditation { get; set; }
        public string TeurConditation { get; set; }
        public string DoctorOpinion { get; set; }
        




        public ConditationMedical DtoTODal()
        {
            var config = new MapperConfiguration(cfg =>

                   cfg.CreateMap<ConditationMedicalDto, ConditationMedical>()
               );
            var mapper = new Mapper(config);
            return mapper.Map<ConditationMedical>(this);
        }
        public static ConditationMedicalDto DalToDto(ConditationMedical a)
        {
            var config = new MapperConfiguration(cfg =>
                 cfg.CreateMap<ConditationMedical, ConditationMedicalDto>()
             );
            var mapper = new Mapper(config);
            return mapper.Map<ConditationMedicalDto>(a);
        }
    }
}
