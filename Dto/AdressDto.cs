using AutoMapper;
using Dal;
//using AutoMapper;
using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;






namespace Dto
{
  public  class AdressDto
    {
        public int CodeAdress { get; set; }
        public string Heaara { get; set; }
        public bool IsParking { get; set; }
        public int NumberFlat { get; set; }
        public Adress DtoTODal()
        {
            var config = new MapperConfiguration(cfg =>

                   cfg.CreateMap<AdressDto, Adress>()
               );
            var mapper = new Mapper(config);
            return mapper.Map<Adress>(this);
        }
        public static AdressDto DalToDto(Adress a)
        {
            var config = new MapperConfiguration(cfg =>
                 cfg.CreateMap<Adress, AdressDto>()
             );
            var mapper = new Mapper(config);
            return mapper.Map<AdressDto>(a);
        }
    }
}
