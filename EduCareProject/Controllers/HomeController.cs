﻿using EduCareProject.Services;
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

        public ActionResult Index()
        {
            var announcement = _announcementService.GetMostRecentAnnouncement();
            var assignment = _assignmentsService.GetMostRecentAssignment();
            return View("Index", _announcementsAssignmentsService.GetAnnouncementsAssignments(announcement, assignment));
        }

        // GET: HomeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HomeController/Create
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        // POST: HomeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HomeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HomeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
