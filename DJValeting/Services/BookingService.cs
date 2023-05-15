using DJValeting.Data;
using DJValeting.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace DJValeting.Services
{
    public class BookingService : IBookingService
    {
        /// <summary>
        /// Business context
        /// </summary>
        private readonly BusinessDbContext _context;

        /// <summary>
        /// Boioking service constructor takes context
        /// </summary>
        /// <param name="context"></param>
        public BookingService(BusinessDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Get all bookings
        /// </summary>
        /// <returns>Enumerable booking</returns>
        public async Task<IEnumerable<Booking>> GetBookings()
        {
            return await _context.Bookings.ToListAsync();
        }

        /// <summary>
        /// Gets specific booking by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Booking</returns>
        public async Task<Booking> GetBookingById(int id)
        {
          return await _context.Bookings.FirstOrDefaultAsync(x => x.Id == id);          
        }
        /// <summary>
        /// Create new booking
        /// </summary>
        /// <param name="booking"></param>
        /// <returns></returns>
        public async Task<Booking> CreateBooking(Booking booking)
        {
            _context.Bookings.Add(booking);
            await _context.SaveChangesAsync();
            return booking;
        }

        /// <summary>
        /// Update existing booking
        /// </summary>
        /// <param name="booking"></param>
        /// <returns></returns>
        public async Task UpdateBooking(Booking booking)
        {
            _context.Bookings.Update(booking);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Delete existing booking
        /// </summary>
        /// <param name="booking"></param>
        /// <returns></returns>
        public async Task DeleteBooking(Booking booking)
        {
            _context.Bookings.Remove(booking);
            await _context.SaveChangesAsync();
        }


    }
}
