using EduCare.Data;
using EduCare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCare.Services
{
    public class AnnouncementService : IAnnouncementService
    {
        private readonly ApplicationDbContext db;

        public AnnouncementService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<Announcement> GetAnnouncements()
        {
            return db.Announcements;
        }
    }
}
