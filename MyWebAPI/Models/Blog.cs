using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MyWebAPI.Models
{
    public class Blog
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string btitle { get; set; }
        [Required]
        public string author { get; set; }

        [DataType(DataType.Date)]
        public DateOnly cdate { get; set; }
        [MaxLength(100)]
        public string comments { get; set; }
    }
}
