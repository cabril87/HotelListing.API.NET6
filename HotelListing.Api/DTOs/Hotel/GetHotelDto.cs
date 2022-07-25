using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListing.Api.DTOs.Hotel
{
    public class HotelDto : BaseHotelDto
    {
        public int Id { get; set; }
    }
}
