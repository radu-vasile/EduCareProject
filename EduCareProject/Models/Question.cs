using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCare.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Content { get; set; }

        public int AssignmentId { get; set; }

        public Assignment Assignment { get; set; }

        public ICollection<Answer> Answers { get; set; }
    }
}
