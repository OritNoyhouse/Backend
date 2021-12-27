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
        public void Post(DailyRouteDto a)
        {
            classDb.AddDailyRoute(a);
        }

        // PUT: api/FastestWay/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/FastestWay/5
        public void Delete(DailyRouteDto a)
        {
            classDb.RemovDailyRoute(a);
        }
    }
}
