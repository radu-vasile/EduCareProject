using EduCareProject.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduCare.Controllers
{
    public class HomeController : Controller
    {
        public readonly IAnnouncementService _announcementService;
        public readonly IAssignmentService _assignmentsService;
        public readonly IAnnouncementsAssignmentsService _announcementsAssignmentsService;
        public HomeController(IAnnouncementService announcementService, IAssignmentService assignmentService, IAnnouncementsAssignmentsService announcementsAssignments)
        {
            _announcementService = announcementService;
            _assignmentsService = assignmentService;
            _announcementsAssignmentsService = announcementsAssignments;
        }
        [Authorize(Roles = "Student, Teacher")]
        public ActionResult Index()
        {
            var announcement = _announcementService.GetMostRecentAnnouncement();
            var assignment = _assignmentsService.GetMostRecentAssignment();
            return View("Index", _announcementsAssignmentsService.GetAnnouncementsAssignments(announcement, assignment));
        }

        [Authorize(Roles = "Student, Teacher")]
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

    }
}
