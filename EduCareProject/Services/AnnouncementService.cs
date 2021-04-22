using EduCare.Data;
using EduCareProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCareProject.Services
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
            return (IEnumerable<Announcement>)db.Announcements;
        }

        public Announcement GetMostRecentAnnouncement()
        {
            return db.Announcements.OrderBy(n => n.CreatedOn).LastOrDefault();
        }

        public Announcement GetAnnouncementById(int? id)
        {
            var announcement = db.Announcements.FirstOrDefault(item => item.Id == id);
            return announcement;
        }

        public void AddAnnouncement(Announcement announcement)
        {
            db.Announcements.Add(announcement);
            db.SaveChanges();
        }

        public void EditAnnouncement(Announcement announcement)
        {
            db.Entry(announcement).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void RemoveAnnouncement(int? id)
        {
            Announcement announcement = db.Announcements.FirstOrDefault(n => n.Id == id);
            db.Announcements.Remove(announcement);
            db.SaveChanges();
        }
    }
}
