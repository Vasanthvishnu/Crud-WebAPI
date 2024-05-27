using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Crud_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        VehicleRepository vech = new VehicleRepository();
        // GET: api/<VehicleController>
        [HttpGet]
        public IEnumerable<VehicleModel> Get()
        {
            return vech.ShowAll();
        }

        // GET api/<VehicleController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<VehicleController>
        [HttpPost]
        public void Post([FromBody]  VehicleModel value)
        {
            vech.Insert(value);
        }

        // PUT api/<VehicleController>/5
        [HttpPut("(Update Vehicle)")]
        public void Put(string VehicleNumber , [FromBody] string DriverName, long Contactnumber)
        {
            vech.Update(DriverName, Contactnumber, VehicleNumber);

        }

        // DELETE api/<VehicleController>/5
        [HttpDelete("RemoveVehicle")]
        public void Delete(string vehiclenumber)
        {
            vech.Remove(vehiclenumber);
        }
    }
}
