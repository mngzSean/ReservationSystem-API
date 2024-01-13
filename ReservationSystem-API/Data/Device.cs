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
        [ForeignKey(nameof(Company))]
        public int CompanyIdx { private get; set; }
        public virtual Company Company { get; set; }

        [Required]
        [ForeignKey(nameof(Facility))]
        public int FacilityIdx { private get; set; }
        public virtual Facility Facility { get; set; }
    }
}
