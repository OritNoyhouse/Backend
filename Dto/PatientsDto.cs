using Dal;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace Dto
{
   
    public enum Gender { male, female }
    public  class PatientsDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Statuscovid19 { get; set; }
        public Gender Gender { get; set; }
        public int CodeAdress { get; set; }
        public int Machine { get; set; }
        public int MedicalCondition { get; set; }
        public int Age { get; set; }
        public int LevelUrgent { get; set; }
        public int doctorId { get; set; }



        public Patient DtoTODal()
        {
            var config = new MapperConfiguration(cfg =>

                   cfg.CreateMap<PatientsDto,Patient>()
               );
            var mapper = new Mapper(config);
            return mapper.Map<Patient>(this);
        }
        public static PatientsDto DalToDto(Patient a)
        {
            var config = new MapperConfiguration(cfg =>
                 cfg.CreateMap<Patient, PatientsDto>()
             );
            var mapper = new Mapper(config);
            return mapper.Map<PatientsDto>(a);
        }
    }
}
