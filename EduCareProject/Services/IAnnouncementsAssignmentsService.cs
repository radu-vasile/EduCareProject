using EduCareProject.Models;
using EduCareProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCareProject.Services
{
    public interface IAnnouncementsAssignmentsService
    {
        public AnnouncementsAssignments GetAnnouncementsAssignments(Announcement announcement, Assignment assignment);
    }
}
