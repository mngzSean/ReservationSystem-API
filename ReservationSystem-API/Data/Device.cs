using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReservationSystem_API.Data
{
    public class Device
    {
        [Key]
        public int Idx { get; private set; }
        [Required]
        public string Pid { get; set; }
        public string Label { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Sn { get; set; }

        [Required]
        [ForeignKey(nameof(Companies))]
        public int CompanyIdx { private get; set; }
        public virtual Company Companies { get; set; }

        [Required]
        [ForeignKey(nameof(Facilities))]
        public int FacilityIdx { private get; set; }
        public virtual Facility Facilities { get; set; }
    }
}
