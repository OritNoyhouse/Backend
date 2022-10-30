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
    public class StatusCovid19Controller : ApiController
    {
        ClassDb classDb = new ClassDb();
        // GET: api/StatusCovid19
        public RequestResult Get()
        {
            return classDb.GetAllStatusCovid19();
        }

        // GET: api/StatusCovid19/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/StatusCovid19
        public void Post(StatusCovidDto a)
        {
            classDb.AddStatusCovid19(a);
        }

        // PUT: api/StatusCovid19/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/StatusCovid19/5
        public void Delete(StatusCovidDto a)
        {
            classDb.RemovStatusCovid19(a);
        }
    }
}
