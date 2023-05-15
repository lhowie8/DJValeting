using System.ComponentModel.DataAnnotations;

namespace DJValeting.Model
{
    public class Flexibility
    {
        public int FlexibilityId { get; set; }
        public string? Name { get; set; }
        public int DisplayOrder { get; set; }

        public virtual ICollection<Booking>? Bookings { get; set; }
    }
}
