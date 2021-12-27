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
    public class DoctorController : ApiController
    {
        ClassDb classDb = new ClassDb();
        // GET: api/Doctor
        public RequestResult Get()
        {
            return classDb.GetAllDoctors();
        }

        // GET: api/Doctor/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Doctor
        public void Post(DoctorsDto a)
        {
            classDb.AddDoctors(a);
        }

        // PUT: api/Doctor/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Doctor/5
        public void Delete(DoctorsDto a)
        {
             classDb.RemoveDoctors(a);
        }
    }
}
