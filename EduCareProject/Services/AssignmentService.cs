using EduCare.Data;
using EduCare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCare.Services
{
    public class AssignmentService : IAssignmentService
    {
        private readonly ApplicationDbContext db;
        public AssignmentService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<Assignment> GetAllAssignments()
        {
            return db.Assignments;
        }
    }
}
