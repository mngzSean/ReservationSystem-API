using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ReservationSystem_API.Data
{
    public class Group
    {
        [Key]
        public int Idx { get; set; }
        public string Name { get; set; }
        [Required]
        [ForeignKey(nameof(Facility))]
        public int FacilityIdx { private get; set; }
        public virtual Facility Facility { get; set; }
    }
}
