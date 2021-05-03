using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCareProject.ViewModels
{
    public class TotalNumberAndCurrentQuestion
    {
        public int totalNumberOfQuestions { get; set; }
        public int currentQuestionId { get; set; }

        public TotalNumberAndCurrentQuestion(int totalNumberOfQuestions, int currentQuestionId)
        {
            this.totalNumberOfQuestions = totalNumberOfQuestions;
            this.currentQuestionId = currentQuestionId;
        }
    }
}
