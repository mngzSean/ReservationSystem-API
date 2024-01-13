using ReservationSystem_API.Data;
using System.Text.Json.Serialization;

namespace ReservationSystem_API.ViewModel
{
    public class DeviceWritableModel : Device
    {
        [JsonIgnore]
        public override Company Company { get; set; }
        [JsonIgnore]
        public override Facility Facility { get; set; }
    }
}
