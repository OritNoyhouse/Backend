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
    public class FastestWayController : ApiController
    {
        ClassDb classDb = new ClassDb();
        // GET: api/FastestWay
        public RequestResult Get()
        {
            return classDb.GetAllDailyRoute();

        }

        // GET: api/FastestWay/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/FastestWay
        public void Post(DailyRouteDto dailyRoute)
        {
            classDb.AddDailyRoute(dailyRoute);
        }
      

        // DELETE: api/FastestWay/5
        public void Delete(DailyRouteDto dailyRoute)
        {
            classDb.RemovDailyRoute(dailyRoute);
        }
    }
}
