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
    public class DailyReportController : ApiController
    {
        ClassDb classDb = new ClassDb();
        // GET: api/DailyReport
        public RequestResult Get()
        {
            return classDb.GetAllDailyReportToDoctor();
        }

        // GET: api/DailyReport/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/DailyReport
        public void Post(DailyReportToDoctorDto a)
        {
            classDb.AddDailyReportToDoctor(a);
        }

        // PUT: api/DailyReport/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/DailyReport/5
        public void Delete( DailyReportToDoctorDto a)
        {
            classDb.RemovDailyReportToDoctor(a);
        }
    }
}
