using EduCare.Data;
using EduCareProject.Models;
using EduCareProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCareProject.Services
{
    public class AssignmentService : IAssignmentService
    {
        private readonly ApplicationDbContext db;
        public AssignmentService(ApplicationDbContext db)
        {
            this.db = db;
        }
        public Assignment GetMostRecentAssignment()
        {
            return db.Assignments.OrderBy(n => n.CreatedOn).LastOrDefault();
        }
        public IEnumerable<Assignment> GetAllAssignments()
        {
            return db.Assignments.OrderByDescending(x => x.CreatedOn);
        }

        public int GetTotalNumberOfQuestionsByAssignmentId(int id)
        {
            var assignment = db.Assignments.FirstOrDefault(r => r.Id == id);
            return assignment.NumberOfQuestions;
        }

        public void AddNewAssignment(Assignment assignment)
        {
            db.Assignments.Add(assignment);
            db.SaveChanges();
        }        
        
        public void AddNewQuestion(Question question)
        {
            db.Questions.Add(question);
            db.SaveChanges();
        }

        public Assignment GetAssignmentById(int id)
        {
            return db.Assignments.FirstOrDefault(a => a.Id == id);
        }

        public IEnumerable<Question> GetAllQuestionsByAssignmentId(int id)
        {
            return db.Questions.Where(q => q.AssignmentId == id);
        }

        public void DeleteAssignment(int id)
        {
            Assignment assignment = db.Assignments.Find(id);
            db.Assignments.Remove(assignment);
            db.SaveChanges();
        }
    }
}
