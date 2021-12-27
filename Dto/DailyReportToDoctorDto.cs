using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using AutoMapper;

namespace Dto
{
 public   class DailyReportToDoctorDto
    {
       
        public int IdDoctor { get; set; }
        public List<Patient>PatientsForTomorrow { get; set; }
        public  List<Adress> AdresessList { get; set; }
        public List<Equipment> Machines { get; set; }
        public List<int> FastestWay { get; set; }








        public DailyReportToDoctor DtoTODal()
        {
            var config = new MapperConfiguration(cfg =>

                   cfg.CreateMap<DailyReportToDoctorDto, DailyReportToDoctor>()
               );
            var mapper = new Mapper(config);
            return mapper.Map<DailyReportToDoctor>(this);
        }
        public static DailyReportToDoctorDto
            DalToDto(DailyReportToDoctor a)
        {
            var config = new MapperConfiguration(cfg =>
                 cfg.CreateMap<DailyReportToDoctor, DailyReportToDoctorDto>()
             );
            var mapper = new Mapper(config);
            return mapper.Map<DailyReportToDoctorDto>(a);
        }
    }
}
