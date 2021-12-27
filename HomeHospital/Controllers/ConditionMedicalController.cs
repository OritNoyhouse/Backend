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
    public class ConditionMedicalController : ApiController
    {
        ClassDb classDb = new ClassDb();
        // GET: api/ConditionMedical
        public RequestResult Get()
        {
            return classDb.GetAllConditationMedical();
        }

        // GET: api/ConditionMedical/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ConditionMedical
        public void Post(ConditationMedicalDto a)
        {
            classDb.AddConditationMedical(a);
        }

        // PUT: api/ConditionMedical/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ConditionMedical/5
        public void Delete(ConditationMedicalDto a)
        {
            classDb.RemovConditationMedical(a);
        }
    }
}
