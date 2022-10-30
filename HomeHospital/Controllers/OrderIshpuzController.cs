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
    public class OrderIshpuzController : ApiController
    {
        
        ClassDb classDb = new ClassDb();
        
       

       

        // PUT: api/OrderIshpuz/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/OrderIshpuz/5
        public void Delete(OrderHomeHospitalizationDto a)
        {
            classDb.RemovOrderHomeHospitalization(a);
        }
        [HttpGet]
        [Route("api/OrderIshpuz/9/{id}")]
        public object GettOrders(int id)
        {

            return classDb.GetAllOrderHomeHospitalization(id).Data; 
        }
        [HttpPost]
        [Route("api/OrderIshpuz/18")]
        public void PostOrderHomeHospitalization(OrderHomeHospitalizationDto a)
        {
            classDb.AddOrderHomeHospitalization(a);
        }
    }
}
