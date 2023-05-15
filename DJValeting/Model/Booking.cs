using System.ComponentModel.DataAnnotations;

namespace DJValeting.Model
{
    /// <summary>
    /// DJValeting booking model
    /// </summary>
    public class Booking
    {
        //Database ID
        public int Id { get; set; }

        /// <summary>
        /// Booking name
        /// </summary>
        [Required]
        public string? Name { get; set; }


        /// <summary>
        /// Booking Date
        /// </summary>
        [Required]
        public DateTime BookingDate { get; set; } = DateTime.Now;

        /// <summary>
        /// Flexibility ID
        /// </summary>
        [Required]
        public int FlexibilityId { get; set; } = 1;
        public virtual Flexibility? Flexibility { get; set; }

        /// <summary>
        /// Vehicle Size ID 
        /// </summary>
        [Required]
        public int VehicleSizeId { get; set; } = 1;

        public virtual VehicleSize? VehicleSize { get; set; }

        /// <summary>
        /// Contact Phone Number
        /// </summary>
        [Required]
        [Phone]
        public string? ContactNumber { get; set; }

        /// <summary>
        /// Email Address
        /// </summary>
        [Required]
        [EmailAddress]
        public string? EmailAddress { get; set; }

        /// <summary>
        /// Approved booking
        /// </summary>
        [Required]
        public bool Approved { get; set; }

    }
}
