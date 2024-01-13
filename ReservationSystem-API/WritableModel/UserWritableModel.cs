using ReservationSystem_API.Data;
using System.Text.Json.Serialization;

namespace ReservationSystem_API.ViewModel
{
    public class UserWritableModel : User
    {
        [JsonIgnore]
        public override Group Group{ get; set; }
    }
}
