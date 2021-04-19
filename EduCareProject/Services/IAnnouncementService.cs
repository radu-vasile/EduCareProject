using EduCare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCare.Services
{
    public interface IAnnouncementService
    {
        public IEnumerable<Announcement> GetAnnouncements();

    }
}
