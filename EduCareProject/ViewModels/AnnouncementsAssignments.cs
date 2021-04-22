using EduCareProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCareProject.ViewModels
{
    public class AnnouncementsAssignments
    {
        public Announcement Announcement { get; set; }
        public Assignment Assignment { get; set; }

        public AnnouncementsAssignments(Announcement announcement, Assignment assignment)
        {
            Announcement = announcement;
            Assignment = assignment;
        }

    }
}
