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
    }
}
