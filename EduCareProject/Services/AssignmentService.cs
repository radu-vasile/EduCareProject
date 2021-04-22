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
            return db.Assignments.OrderBy(n => n.CreatedOn).FirstOrDefault();
        }
        public IEnumerable<Assignment> GetAllAssignments()
        {
            return db.Assignments;
        }
    }
}
