using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Dal;
//using AutoMapper;

namespace Dto
{
    public class EquipmentDto
    {
        public int CodeMachine { get; set; }
        public string NameMachine { get; set; }
       
       

      
        public Equipment DtoTODal()
        {
            var config = new MapperConfiguration(cfg =>

                   cfg.CreateMap<EquipmentDto, Equipment>()
               );
            var mapper = new Mapper(config);
            return mapper.Map<Equipment>(this);
        }
        public static EquipmentDto DalToDto(Equipment a)
        {
            var config = new MapperConfiguration(cfg =>
                 cfg.CreateMap<Equipment, EquipmentDto>()
             );
            var mapper = new Mapper(config);
            return mapper.Map<EquipmentDto>(a);
        }
    }
}
