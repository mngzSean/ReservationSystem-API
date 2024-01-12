using System.ComponentModel.DataAnnotations;

namespace ReservationSystem_API.Data
{
    public class Company
    {
        [Key]
        public int Idx { get; private set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Mail { get; set; }
        public string Address { get; set; }
    }
}
