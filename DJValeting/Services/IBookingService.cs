using DJValeting.Model;
namespace DJValeting.Services
{
    /// <summary>
    /// Interface for booking service
    /// </summary>
    public interface IBookingService
    {
        /// <summary>
        /// Gets all bookings
        /// </summary>
        /// <returns>Enumerable Booking Model</returns>
        Task<IEnumerable<Booking>> GetBookings();
        /// <summary>
        /// Get specific Booking by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Booking model</returns>
        Task<Booking> GetBookingById(int id);
        /// <summary>
        /// Create new booking
        /// </summary>
        /// <param name="booking"></param>
        /// <returns>Booking model</returns>
        Task<Booking> CreateBooking(Booking booking);
        /// <summary>
        /// Update existing booking
        /// </summary>
        /// <param name="booking"></param>
        /// <returns></returns>
        Task UpdateBooking(Booking booking);
        /// <summary>
        /// Delete existing booking
        /// </summary>
        /// <param name="booking"></param>
        /// <returns></returns>
        Task DeleteBooking(Booking booking);
    }
}
