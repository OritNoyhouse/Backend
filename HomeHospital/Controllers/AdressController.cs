using Bll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Dto;
using System.Web.Http.Cors;


namespace HomeHospital.Controllers
{

    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class AdressController : ApiController
    {
        ClassDb classDb = new ClassDb();

        // DELETE: api/Adress/5
        public void Delete(AdressDto adress)
        {
            classDb.RemoveAddress(adress);
        }
        [HttpPost]
        [Route("api/Adress/8")]
        public void PostAdress(AdressDto adress,int id)
        {
            classDb.AddAddress(adress,id);
        }
       
    }
}
}
