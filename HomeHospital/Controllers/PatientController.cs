using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Dto;
using Bll;
using System.Web.Http.Cors;

namespace HomeHospital.Controllers
{

    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class PatientController : ApiController
    {
       
        ClassDb classDb = new ClassDb();
       

       
       
        // PUT: api/Patient/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Patient/5
        public void Delete(PatientsDto a)
        {
            classDb.RemovePatients(a);
        }
       
       
        [HttpPost]
        [Route("api/Patient/8")]
        public void PostPatient(PatientsDto a)
        {
             classDb.AddPatients(a);
        }
        [HttpGet]
        [Route("api/Patient/18/{password}")]
        public object GettPatient( string password)
        {
            
            return classDb.GetPatient(password).Data; ;
        }
       
    }
}
