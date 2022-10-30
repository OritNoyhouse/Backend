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
    public class MachineToPatientController : ApiController
    {
        ClassDb classDb = new ClassDb();
        // GET: api/MachineToPatient
        public RequestResult Get()
        {
            return classDb.GetAllEnquipmentOfPatient();
        }

       

        // POST: api/MachineToPatient
        public void Post(EnquipmentOfPatientDto a)
        {
            classDb.AddEnquipmentOfPatient(a);
        }

        // PUT: api/MachineToPatient/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/MachineToPatient/5
        public void Delete(EnquipmentOfPatientDto a)
        {
            classDb.RemovEnquipmentOfPatient(a);
        }
    }
}
