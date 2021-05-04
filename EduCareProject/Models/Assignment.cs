using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCareProject.Models
{
    public class Assignment
    {
        public int Id { get; set; }
        [Required]
        [StringLength(500, MinimumLength = 5)]
        public string Title { get; set; }

        [Required]
        [StringLength(500, MinimumLength = 5)]
        public string Description { get; set; }

        public DateTime CreatedOn { get; set; }

        [Required]
        [Range(1, 10, ErrorMessage = "Please enter a value bigger than 1 and greater than 10")]

        public int NumberOfQuestions { get; set; }

        public ICollection<Question> Questions { get; set; }
    }
}
