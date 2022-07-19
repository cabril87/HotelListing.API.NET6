using Microsoft.EntityFrameworkCore;

namespace HotelListing.Api.Data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Cuba",
                    ShortName = "CU"
                },
                new Country
                {
                    Id = 2,
                    Name = "Bahamas",
                    ShortName = "BS"
                },
                new Country
                {
                    Id = 3,
                    Name = "Dominican Republic",
                    ShortName = "DR"
                }
             );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Sandal Resort and Spa",
                    Address = "Negril",
                    CountryId = 2,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Marriot",
                    Address = "Goerge Town",
                    CountryId = 3,
                    Rating = 4.0
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Comfort Suites",
                    Address = "Grand Palldium",
                    CountryId = 1,
                    Rating = 4.7
                }
             );
        }
    }
}
