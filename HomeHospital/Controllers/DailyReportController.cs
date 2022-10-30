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
    public class DailyReportController : ApiController
    {
        ClassDb classDb = new ClassDb();

        // POST: api/DailyReport
        public void Post(DailyReportToDoctorDto dailyReport)
        {
            classDb.AddDailyReportToDoctor(dailyReport);
        }

        // DELETE: api/DailyReport/5
        public void Delete( DailyReportToDoctorDto dailyReport)
        {
            classDb.RemovDailyReportToDoctor(dailyReport);
        }
        [HttpGet]
        [Route("api/DailyReport/9/{id}/{date}")]
        public object GettDailyReport(int id,int date) 
        {
            object obj = classDb.GetDailyReportToDoctor(id,date).Data;
            return obj;
        }

    }
}

