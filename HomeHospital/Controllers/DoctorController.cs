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
    public class DoctorController : ApiController
    {

        ClassDb classDb = new ClassDb();
        // POST: api/Doctor
        public void Post(DoctorsDto doctor)
        {
            classDb.AddDoctors(doctor);
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
        [HttpPost]
        [Route("api/Doctor/8")]
        public void PostDoctor(DoctorsDto a)
        {
            classDb.AddDoctors(a);
        }
        [HttpGet]
        [Route("api/Doctor/18/{password}")]
        public object GettDoctor(string password)
        {

            return classDb.GetDoctor(password).Data; 
        }

    }
}
