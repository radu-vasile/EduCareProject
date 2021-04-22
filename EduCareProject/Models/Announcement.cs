using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCareProject.Models
{
    public class Announcement
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        [StringLength(500, MinimumLength = 10)]
        public string Description { get; set; }

        public String UserID { get; set; }

        [ForeignKey("UserID")]
        public ApplicationUser User { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
