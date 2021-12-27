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


    public class DoctorsDto
    {
        
      
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Statuscovid19 { get; set; }
            public Gender Gender { get; set; }
            public int Location { get; set; }
            public int HoursOfWork { get; set; }
           
            public int LevelUrgent { get; set; }
            public Doctor DtoTODal()
            {
                var config = new MapperConfiguration(cfg =>

                       cfg.CreateMap<DoctorsDto, Doctor>()
                   );
                var mapper = new Mapper(config);
                return mapper.Map<Doctor>(this);
            }
            public static DoctorsDto DalToDto(Doctor a)
            {
                var config = new MapperConfiguration(cfg =>
                     cfg.CreateMap<Doctor, DoctorsDto>()
                 );
                var mapper = new Mapper(config);
                return mapper.Map<DoctorsDto>(a);
            }
        }
    }

