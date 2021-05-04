using EduCareProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCareProject.ViewModels
{
    public class QuestionAssignmentViewModel
    {
        public int totalNumberOfQuestions { get; set; }
        public Question question { get; set; }
        public int currentQuestionNumber { get; set; }

    }
}
