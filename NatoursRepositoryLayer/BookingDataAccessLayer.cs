using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NatoursEntities;
using NatoursExceptions;
using NatoursRepositoryLayer.Convertor;
using NatoursRepositoryLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatoursRepositoryLayer
{
    public class BookingDataAccessLayer : IBookingDataAccessLayer
    {
        private readonly NatoursDbContext _dbcontext;
        private readonly IMapper _mapper;
        public BookingDataAccessLayer(NatoursDbContext dbcontext, IMapper mapper)
        {
            _dbcontext = dbcontext;
            _mapper = mapper;
        }
        public async Task<List<BookingEntity>> GetAllBookingDetails()
        {
            List<Booking> getAllBookingDetails = _dbcontext.bookings.ToList<Booking>();
            List<BookingEntity> bookingEntities = new List<BookingEntity>();

            BookingEntity bookingEntity = null;
            foreach (var item in getAllBookingDetails)
            {
                bookingEntity = new BookingEntity();
                bookingEntity=  _mapper.Map<BookingEntity>(item);
                bookingEntities.Add(bookingEntity);
            }
            return bookingEntities;
        }

        public async Task<bool> BookPackageAdd(BookingEntity entity)
        {
            try
            {
                List<Booking> getAllBookingDetails = _dbcontext.bookings.ToList<Booking>();
                var data = getAllBookingDetails.FirstOrDefault(x => x.CustomerId == entity.CustomerId && x.PackageId == entity.PackageId &&
                ( x.StatusId==(int)Constants.StatusConstant.InProgress || x.StatusId == (int)Constants.StatusConstant.Approved));

                if (data != null)
                    throw new PackageAlreadyBooked("Please wait Your request is in Progress or not Completed");

                Booking booking = _mapper.Map<Booking>(entity);
                await _dbcontext.bookings.AddAsync(booking);
                await _dbcontext.SaveChangesAsync();
                
            }
            catch(PackageAlreadyBooked ex)
            {
                return false;
            }catch(Exception ex)
            {
                return false;
            }
            return true;
        }

        public async Task<bool> BookPackageUpdate(BookingEntity entity)
        {
            try
            {
                List<Booking> getAllBookingDetails = _dbcontext.bookings.ToList<Booking>();
                var data = getAllBookingDetails.FirstOrDefault(x => x.CustomerId == entity.CustomerId && x.PackageId == entity.PackageId);

                if (data == null)
                    throw new PackageNotFound("Package Not Found for this Customer");

                Booking booking = _mapper.Map<Booking>(entity);
                _dbcontext.Entry(await _dbcontext.bookings.FirstOrDefaultAsync(x => x.BookingId == entity.BookingId)).CurrentValues.SetValues(booking);               
                await _dbcontext.SaveChangesAsync();

            }
            catch (PackageNotFound ex)
            {
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
