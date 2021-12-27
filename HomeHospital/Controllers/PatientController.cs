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
    public class PatientController : ApiController
    {
        ClassDb classDb = new ClassDb();
        // GET: api/Patient
        public RequestResult Get()
        {
            return classDb.GetAllPatients();
        }

        // GET: api/Patient/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Patient
        public void Post(PatientsDto a)
        {
            classDb.AddPatients(a);
        }

        // PUT: api/Patient/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Patient/5
        public void Delete(PatientsDto a)
        {
            classDb.RemovePatients(a);
        }
    }
}
