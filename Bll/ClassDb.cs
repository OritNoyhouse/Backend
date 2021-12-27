using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Dto;

namespace Bll
{
    public class ClassDb
    {
     

        public OritProjectGoodLuckEntities2 db = OritProjectGoodLuckEntities2.Instance();


        //Address
        public RequestResult GetAllAddress()  
        {
            List<AdressDto> lst = new List<AdressDto>();
            foreach (var item in db.Adress.ToList())
            {
                lst.Add(AdressDto.DalToDto(item));
            }
            return new RequestResult() { Data = lst, Message = "success", Status = true };
        }
        public void AddAddress(AdressDto a)
        {
            db.Adress.Add(a.DtoTODal());
            db.SaveChanges();
        }
        public void RemoveAddress(AdressDto a)
        {
            db.Adress.Remove(a.DtoTODal());
            db.SaveChanges();
        }
        //Patient
        public RequestResult GetAllPatients()
        {
            List<PatientsDto> lst = new List<PatientsDto>();
            foreach (var item in db.Patient.ToList())
            {
                lst.Add(PatientsDto.DalToDto(item));
            }
            return new RequestResult() { Data = lst, Message = "success", Status = true };
        }
        public void AddPatients(PatientsDto a)
        {
            db.Patient.Add(a.DtoTODal());
            db.SaveChanges();
        }
        public void RemovePatients(PatientsDto a)
        {
            db.Patient.Remove(a.DtoTODal());
            db.SaveChanges();
        }
        //doctor
        public RequestResult GetAllDoctors()
        {
            List<DoctorsDto> lst = new List<DoctorsDto>();
            foreach (var item in db.Doctor.ToList())
            {
                lst.Add(DoctorsDto.DalToDto(item));
            }
            return new RequestResult() { Data = lst, Message = "success", Status = true };
        }
        public void AddDoctors(DoctorsDto a)
        {
            db.Doctor.Add(a.DtoTODal());
            db.SaveChanges();
        }
        public void RemoveDoctors(DoctorsDto a)
        {
            db.Doctor.Remove(a.DtoTODal());
            db.SaveChanges();
        }
        //ScheduleForDoctor
        public RequestResult GetAllScheduleForDoctor()
        {
            List<ScheduleForDoctorDto> lst = new List<ScheduleForDoctorDto>();
            foreach (var item in db.ScheduleForDoctor.ToList())
            {
                lst.Add(ScheduleForDoctorDto.DalToDto(item));
            }
            return new RequestResult() { Data = lst, Message = "success", Status = true };
        }
        public void AddScheduleForDoctor(ScheduleForDoctorDto a)
        {
            db.ScheduleForDoctor.Add(a.DtoTODal());
            db.SaveChanges();
        }
        public void RemoveScheduleForDoctor(ScheduleForDoctorDto a)
        {
            db.ScheduleForDoctor.Remove(a.DtoTODal());
            db.SaveChanges();
        }
        //Equipment
        public RequestResult GetAllEquipment()
        {
            List<EquipmentDto> lst = new List<EquipmentDto>();
            foreach (var item in db.Equipment.ToList())
            {
                lst.Add(EquipmentDto.DalToDto(item));
            }
            return new RequestResult() { Data = lst, Message = "success", Status = true };
        }
        public void AddEquipment(EquipmentDto a)
        {
            db.Equipment.Add(a.DtoTODal());
            db.SaveChanges();
        }
        public void RemovEquipment(EquipmentDto a)
        {
            db.Equipment.Remove(a.DtoTODal());
            db.SaveChanges();
        }
        //ConditationMedical
        public RequestResult GetAllConditationMedical()
        {
            List<ConditationMedicalDto> lst = new List<ConditationMedicalDto>();
            foreach (var item in db.ConditationMedical.ToList())
            {
                lst.Add(ConditationMedicalDto.DalToDto(item));
            }
            return new RequestResult() { Data = lst, Message = "success", Status = true };
        }
        public void AddConditationMedical(ConditationMedicalDto a)
        {
            db.ConditationMedical.Add(a.DtoTODal());
            db.SaveChanges();
        }
        public void RemovConditationMedical(ConditationMedicalDto a)
        {
            db.ConditationMedical.Remove(a.DtoTODal());
            db.SaveChanges();
        }


        //EnquipmentOfPatient
        public RequestResult GetAllEnquipmentOfPatient()
        {
            List<EnquipmentOfPatientDto> lst = new List<EnquipmentOfPatientDto>();
            foreach (var item in db.EquipmentOfPatient.ToList())
            {
                lst.Add(EnquipmentOfPatientDto.DalToDto(item));
            }
            return new RequestResult() { Data = lst, Message = "success", Status = true };
        }
        public void AddEnquipmentOfPatient(EnquipmentOfPatientDto a)
        {
            db.EquipmentOfPatient.Add(a.DtoTODal());
            db.SaveChanges();
        }
        public void RemovEnquipmentOfPatient(EnquipmentOfPatientDto a)
        {
            db.EquipmentOfPatient.Remove(a.DtoTODal());
            db.SaveChanges();
        }
        //StatusCovid19
        public RequestResult GetAllStatusCovid19()
        {
            List<StatusCovidDto> lst = new List<StatusCovidDto>();
            foreach (var item in db.StatusCovid19.ToList())
            {
                lst.Add(StatusCovidDto.DalToDto(item));
            }
            return new RequestResult() { Data = lst, Message = "success", Status = true };
        }
        public void AddStatusCovid19(StatusCovidDto a)
        {
            db.StatusCovid19.Add(a.DtoTODal());
            db.SaveChanges();
        }
        public void RemovStatusCovid19(StatusCovidDto a)
        {
            db.StatusCovid19.Remove(a.DtoTODal());
            db.SaveChanges();
        }
        //DailyRoute
        public RequestResult GetAllDailyRoute()
        {
            List<DailyRouteDto> lst = new List<DailyRouteDto>();
            foreach (var item in db.DailyRoute.ToList())
            {
                lst.Add(DailyRouteDto.DalToDto(item));
            }
            return new RequestResult() { Data = lst, Message = "success", Status = true };
        }
        public void AddDailyRoute(DailyRouteDto a)
        {
            db.DailyRoute.Add(a.DtoTODal());
            db.SaveChanges();
        }
        public void RemovDailyRoute(DailyRouteDto a)
        {
            db.DailyRoute.Remove(a.DtoTODal());
            db.SaveChanges();
        }
        //DailyDailyReportToDoctor
        public RequestResult GetAllDailyReportToDoctor()
        {
            List<DailyReportToDoctorDto> lst = new List<DailyReportToDoctorDto>();
            foreach (var item in db.DailyReportToDoctor.ToList())
            {
                lst.Add(DailyReportToDoctorDto.DalToDto(item));
            }
            return new RequestResult() { Data = lst, Message = "success", Status = true };
        }
        public void AddDailyReportToDoctor(DailyReportToDoctorDto a)
        {
            db.DailyReportToDoctor.Add(a.DtoTODal());
            db.SaveChanges();
        }
        public void RemovDailyReportToDoctor(DailyReportToDoctorDto a)
        {
            db.DailyReportToDoctor.Remove(a.DtoTODal());
            db.SaveChanges();
        }

        //OrderHomeHospitalization
        public RequestResult GetAllOrderHomeHospitalization()
        {
            List<OrderHomeHospitalizationDto> lst = new List<OrderHomeHospitalizationDto>();
            foreach (var item in db.OrderHomeHospitalization.ToList())
            {
                lst.Add(OrderHomeHospitalizationDto.DalToDto(item));
            }
            return new RequestResult() { Data = lst, Message = "success", Status = true };
        }
        public void AddOrderHomeHospitalization(OrderHomeHospitalizationDto a)
        {
            db.OrderHomeHospitalization.Add(a.DtoTODal());
            db.SaveChanges();
        }
        public void RemovOrderHomeHospitalization(OrderHomeHospitalizationDto a)
        {
            db.OrderHomeHospitalization.Remove(a.DtoTODal());
            db.SaveChanges();
        }

    }
}
