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

        // POST: api/ConditionMedical
        public void Post(ConditationMedicalDto conditationMedical)
        {
            classDb.AddConditationMedical(conditationMedical);
        }


        // DELETE: api/ConditionMedical/5
        public void Delete(ConditationMedicalDto conditationMedical)
        {
            classDb.RemovConditationMedical(conditationMedical);
        }
    }
}
