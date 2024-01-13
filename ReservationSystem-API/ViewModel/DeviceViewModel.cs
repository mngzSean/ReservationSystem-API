using ReservationSystem_API.Data;
using System.Text.Json.Serialization;

namespace ReservationSystem_API.ViewModel
{
    public class DeviceViewModel : Device
    {
        [JsonIgnore]
        public override Company Companies { get; set; }
        [JsonIgnore]
        public override Facility Facilities { get; set; }
    }
}
