using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Dal;

namespace Dto
{
   public class EnquipmentOfPatientDto
    {
        public int IdMachine{ get; set; }
        public int IdPatient { get; set; }

        public DateTime DateOfTake { get; set; }
        public DateTime DateOfReturn { get; set; }





        public EquipmentOfPatient DtoTODal()
        {
            var config = new MapperConfiguration(cfg =>

                   cfg.CreateMap<EnquipmentOfPatientDto, EquipmentOfPatient>()
               );
            var mapper = new Mapper(config);
            return mapper.Map<EquipmentOfPatient>(this);
        }
        public static EnquipmentOfPatientDto
            DalToDto(EquipmentOfPatient a)
        {
            var config = new MapperConfiguration(cfg =>
                 cfg.CreateMap<EquipmentOfPatient, EnquipmentOfPatientDto>()
             );
            var mapper = new Mapper(config);
            return mapper.Map<EnquipmentOfPatientDto>(a);
        }
    }
}
