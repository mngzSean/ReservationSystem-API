using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace ReservationSystem_API.Data
{
    public class Facility
    {
        [Key]
        public int Idx { get; private set; }
        [Required]
        public string Name { get; set; }
        public string Purpose{ get; set; }
        public string Location { get; set; }
    }
}
