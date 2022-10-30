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
    public class MachinesController : ApiController
    {
        ClassDb classDb = new ClassDb();
        // GET: api/Machines
        public RequestResult Get()
        {
            return classDb.GetAllEquipment();
        }

        // GET: api/Machines/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Machines
        public void Post(EquipmentDto a)
        {
            classDb.AddEquipment(a);
        }

        // PUT: api/Machines/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Machines/5
        public void Delete(EquipmentDto a)
        {
            classDb.RemovEquipment(a);
        }
    }
}
