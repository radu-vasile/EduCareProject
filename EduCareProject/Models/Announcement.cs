using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCare.Models
{
    public class Announcement
    {
        public int Id { get; set; }

        public int Title { get; set; }
        public int Description { get; set; }

        public String UserID { get; set; }

        [ForeignKey("UserID")]
        public ApplicationUser User { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
