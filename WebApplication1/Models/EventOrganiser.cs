using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class EventOrganiser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EventOrganiserId { get; set; }
        
        [Required]
        [ForeignKey("Event")]
        public int IdEvent { get; set; }
        
        public Event Event { get; set; }
        
        [Required]
        [ForeignKey("Organiser")]
        public int IdOrganiser { get; set; }
        
        public Organiser Organiser { get; set; }
        
    }
}