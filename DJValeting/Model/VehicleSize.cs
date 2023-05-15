namespace DJValeting.Model
{
    public class VehicleSize
    {
        public int VehicleSizeId { get; set; }
        public string? Name { get; set; }
        public int DisplayOrder { get; set; }
        public virtual ICollection<Booking>? Bookings { get; set; }
    }
}
