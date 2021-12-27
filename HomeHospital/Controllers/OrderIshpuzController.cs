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
    public class OrderIshpuzController : ApiController
    {
        // GET: api/OrderIshpuz
        ClassDb classDb = new ClassDb();
        public RequestResult Get()
        {
            return classDb.GetAllOrderHomeHospitalization();
        }

        // GET: api/OrderIshpuz/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/OrderIshpuz
        public void Post(OrderHomeHospitalizationDto a)
        {
            classDb.AddOrderHomeHospitalization(a);
        }

        // PUT: api/OrderIshpuz/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/OrderIshpuz/5
        public void Delete(OrderHomeHospitalizationDto a)
        {
            classDb.RemovOrderHomeHospitalization(a);
        }
    }
}
