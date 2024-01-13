using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReservationSystem_API.Data
{
    public class ReservationAlive
    {
        [Key]
        public int Idx { get; set; }
        [Required]
        [ForeignKey(nameof(ReservationHistory))]
        public int RHIdx { private get; set; }
        public virtual ReservationHistory ReservationHistory { get; set; }
        [Required]
        [ForeignKey(nameof(Facility))]
        public int FacilityIdx { private get; set; }
        public virtual Facility Facility { get; set; }
        [Required]
        [ForeignKey(nameof(Space))]
        public int SpaceIdx { private get; set; }
        public virtual Space Space { get; set; }
        [Required]
        [ForeignKey(nameof(User))]
        public int UserIdx{ private get; set; }
        public virtual User User{ get; set; }
        [Required]
        [ForeignKey(nameof(Device))]
        public int DeviceIdx { private get; set; }
        public virtual Device Device { get; set; }
    }
}
