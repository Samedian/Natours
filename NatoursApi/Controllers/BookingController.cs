using Microsoft.AspNetCore.Mvc;
using NatoursEntities;
using NatoursServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NatoursApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingBusinessLayer _bookingBusinessLayer;
        public BookingController(IBookingBusinessLayer bookingBusinessLayer)
        {
            this._bookingBusinessLayer = bookingBusinessLayer;
        }

        // GET: api/<BookingController>
        [HttpGet]
        public List<BookingEntity> Get()
        {
            List<BookingEntity> listOfAllBookingDetails = _bookingBusinessLayer.GetAllBookingDetails();

            return listOfAllBookingDetails;
        }

        // GET api/<BookingController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BookingController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BookingController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BookingController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
