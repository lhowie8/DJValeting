using DJValeting.Model;
using Microsoft.EntityFrameworkCore;

namespace DJValeting.Data
  
{
    /// <summary>
    /// Business model data context
    /// </summary>
    public class BusinessDbContext : DbContext
    {
        public BusinessDbContext(DbContextOptions<BusinessDbContext> options) : base(options)
        {
        }
        /// <summary>
        /// Bookings data set 
        /// </summary>
        public DbSet<Booking> Bookings { get; set; }
        /// <summary>
        /// Flexibilities data set
        /// </summary>
        public DbSet<Flexibility> Flexibilities { get; set; }
        /// <summary>
        /// Vehicle Sizes data set
        /// </summary>
        public DbSet<VehicleSize> VehicleSizes { get; set; }

        /// <summary>
        /// Seed static data for data sets
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Flexibility>().HasData(
                new Flexibility
                {
                    FlexibilityId = 1,
                    Name = "+/- 1 Day",
                    DisplayOrder = 1
                },
                 new Flexibility
                 {
                     FlexibilityId = 2,
                     Name = "+/- 2 Days",
                     DisplayOrder = 2
                 },
                 new Flexibility
                 {
                     FlexibilityId = 3,
                     Name = "+/- 3 Days",
                     DisplayOrder = 3
                 }

            );

            modelBuilder.Entity<VehicleSize>().HasData(
               new VehicleSize
               {
                   VehicleSizeId = 1,
                   Name = "Small",
                   DisplayOrder = 1
               },
                new VehicleSize
                {
                    VehicleSizeId = 2,
                    Name = "Medium",
                    DisplayOrder = 2
                },
                new VehicleSize
                {
                    VehicleSizeId = 3,
                    Name = "Large",
                    DisplayOrder = 3
                },
                  new VehicleSize
                  {
                      VehicleSizeId = 4,
                      Name = "Van",
                      DisplayOrder = 4
                  }

           );
        }
    }
}
