using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReservationSystem_API.Data
{
    public class Space
    {
        [Key]
        public int Idx { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        [Required]
        [ForeignKey(nameof(Facility))]
        public int FacilityIdx { private get; set; }
        public virtual Facility Facility { get; set; }
    }
}
