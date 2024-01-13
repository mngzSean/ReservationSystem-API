using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ReservationSystem_API.Data
{
    public class User
    {
        [Key]
        public int Idx { get; private set; }
        [Required]
        public string Name { get; set; }
        public string Birth { get; set; }
        public string Sex { get; set; }
        public string Contact { get; set; }
        public int Valid { get; set; }
        public DateOnly JoinDate { get; set; }

        [Required]
        [ForeignKey(nameof(Group))]
        public int GroupIdx { private get; set; }
        public virtual Group Group { get; set; }
    }
}
