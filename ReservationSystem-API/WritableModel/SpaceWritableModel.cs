using ReservationSystem_API.Data;
using System.Text.Json.Serialization;

namespace ReservationSystem_API.ViewModel
{
    public class SpaceWritableModel : Space
    {
        [JsonIgnore]
        public override Facility Facility { get; set; }
    }
}
