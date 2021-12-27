using Bll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Dto;


namespace HomeHospital.Controllers
{
    public class AdressController : ApiController
    {
        ClassDb classDb = new ClassDb();
        // GET: api/Adress
        public RequestResult Get()
        {
            return classDb.GetAllAddress();
        }

        // GET: api/Adress/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Adress
        public void Post(AdressDto a)
        {
            classDb.AddAddress(a);
        }

        // PUT: api/Adress/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Adress/5
        public void Delete(AdressDto a)
        {
            classDb.RemoveAddress(a);
        }
    }
}
