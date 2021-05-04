using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCareProject.Models
{
    public class Question
    {
        public int Id { get; set; }
        [Required]
        [StringLength(500, MinimumLength = 10)]
        public string Content { get; set; }

        public int AssignmentId { get; set; }

        public Assignment Assignment { get; set; }
        [Required]
        [StringLength(500, MinimumLength = 1)]
        public string FirstAnswer { get; set; }
        [Required]
        [StringLength(500, MinimumLength = 1)]
        public string SecondAnswer { get; set; }
        [Required]
        [StringLength(500, MinimumLength = 1)]
        public string ThirdAnswer { get; set; }
        [Required]
        public int CorrectAnswer { get; set; }
    }
}
