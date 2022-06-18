using Microsoft.AspNetCore.Authorization;
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
        private readonly IBookingService _bookingBusinessLayer;
        public BookingController(IBookingService bookingBusinessLayer)
        {
            this._bookingBusinessLayer = bookingBusinessLayer;
        }

        [Authorize(Roles ="Admin")]
        [HttpGet("GetAllBookingInfo")]
        public async Task<List<BookingEntity>> GetAllBookings()
        {
            List<BookingEntity> listOfAllBookingDetails = await _bookingBusinessLayer.GetAllBookingDetails();
            return listOfAllBookingDetails;
        }

        [Authorize(Roles = "User")]
        [HttpPost("InsertBooking")]
        public async Task<bool> AddBooking(BookingEntity entity)
        {
            bool result = await _bookingBusinessLayer.BookPackageUpdate(entity);
            return result;
        }

        [Authorize(Roles = "Admin")]
        [HttpPut("UpdateBooking")]
        public async Task<bool> UpdateBooking(BookingEntity entity)
        {
            bool result = await _bookingBusinessLayer.BookPackageUpdate(entity);
            return result;
        }

    }
}
