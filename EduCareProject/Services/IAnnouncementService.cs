using EduCareProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCareProject.Services
{
    public interface IAnnouncementService
    {
        public IEnumerable<Announcement> GetAnnouncements();

        public Announcement GetAnnouncementById(int? id);

        public Announcement GetMostRecentAnnouncement();

        public void AddAnnouncement(Announcement announcement);

        public void EditAnnouncement(Announcement announcement);

        public void RemoveAnnouncement(int? id);

    }
}
