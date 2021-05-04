using EduCareProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCareProject.Services
{
    public interface IAssignmentService
    {
        public Assignment GetMostRecentAssignment();
        public IEnumerable<Assignment> GetAllAssignments();

        public int GetTotalNumberOfQuestionsByAssignmentId(int id);
        public void AddNewAssignment(Assignment assignment);
        public void AddNewQuestion(Question question);

        public Assignment GetAssignmentById(int id);

        public IEnumerable<Question> GetAllQuestionsByAssignmentId(int id);

        public void DeleteAssignment(int id);
    }
}
