using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace ReservationSystem_API.Data
{
    public class Facility
    {
        public int Idx { get; set; }
        public string Name { get; set; }
        public string Purpose{ get; set; }
        public string Location { get; set; }
    }
}
