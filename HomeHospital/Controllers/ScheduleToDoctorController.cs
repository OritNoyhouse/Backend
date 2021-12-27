using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Dto;
using Bll;

namespace HomeHospital.Controllers
{
    public class ScheduleToDoctorController : ApiController
    {
        ClassDb classDb = new ClassDb();
        // GET: api/ScheduleToDoctor
        public RequestResult Get()
        {
            return classDb.GetAllScheduleForDoctor();
        }

        // GET: api/ScheduleToDoctor/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ScheduleToDoctor
        public void Post(ScheduleForDoctorDto a)
        {
            classDb.AddScheduleForDoctor(a);
        }

        // PUT: api/ScheduleToDoctor/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ScheduleToDoctor/5
        public void Delete(ScheduleForDoctorDto a)
        {
            classDb.RemoveScheduleForDoctor(a);
        }
    }
}
