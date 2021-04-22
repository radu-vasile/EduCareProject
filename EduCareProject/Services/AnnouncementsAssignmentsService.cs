using EduCare.Data;
using EduCareProject.Models;
using EduCareProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCareProject.Services
{
    public class AnnouncementsAssignmentsService : IAnnouncementsAssignmentsService
    {
        private readonly ApplicationDbContext db;

        public AnnouncementsAssignmentsService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public AnnouncementsAssignments GetAnnouncementsAssignments(Announcement announcement, Assignment assignment)
        {
            return new AnnouncementsAssignments(announcement, assignment);
        }
    }
}
