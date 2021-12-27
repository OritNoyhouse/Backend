using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Dal;

namespace Dto
{
   public class ScheduleForDoctorDto
    {
        public int IdDoctor { get; set; }
        public int IdMishmeret { get; set; }
        public char Day { get; set; }
        public int FromHour { get; set; }
        public int ToHour { get; set; }




        public ScheduleForDoctor DtoTODal()
        {
            var config = new MapperConfiguration(cfg =>

                   cfg.CreateMap<ScheduleForDoctorDto, ScheduleForDoctor>()
               );
            var mapper = new Mapper(config);
            return mapper.Map<ScheduleForDoctor>(this);
        }
        public static ScheduleForDoctorDto DalToDto(ScheduleForDoctor a)
        {
            var config = new MapperConfiguration(cfg =>
                 cfg.CreateMap<ScheduleForDoctor, ScheduleForDoctorDto>()
             );
            var mapper = new Mapper(config);
            return mapper.Map<ScheduleForDoctorDto>(a);
        }
    }
}
