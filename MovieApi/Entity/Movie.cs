using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;





namespace MovieApi.Entities
{
    [Table("Movie")]
  public class Movie
 {
    [Key]
        public int MovieId { get; set; }
    [StringLength(20)]
    [Column(TypeName = "varchar")]
    [Required]
	public string Actor { get; set; }   
        public string Director { get; set; }
        public string MovieName { get; set; }
        public string Language { get; set;}
        public int ReleaseYear { get; set; }
        
 }
}