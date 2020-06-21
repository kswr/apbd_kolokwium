using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;

namespace WebApplication1.Models
{
    public class ArtistEvent
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ArtistEventId { get; set; }
        
        [Required]
        [ForeignKey("Event")]
        public int IdEvent { get; set; }
        
        public Event Event { get; set; }
        
        [Required]
        [ForeignKey("Artist")]
        public int IdArtist { get; set; }
        
        public Artist Artist { get; set; }
    }
}