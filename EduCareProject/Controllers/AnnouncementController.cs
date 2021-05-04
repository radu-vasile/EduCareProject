using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EduCareProject.Models;
using EduCareProject.Services;
using System.Net;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace EduCareProject.Controllers
{
    public class AnnouncementController : Controller
    {

        public readonly IAnnouncementService _announcementService;

        public AnnouncementController(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
        }

        [Authorize(Roles = "Student, Teacher")]
        public ActionResult Index()
        {
            var announcements = _announcementService.GetAnnouncements();
            return View("Index", announcements);
        }

        [Authorize(Roles = "Teacher")]
        public ActionResult Create()
        {
            return View();
        }

        [Authorize(Roles = "Teacher")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] Announcement announcement)
        {
            if(ModelState.IsValid)
            {
                var claimsIdentity = (ClaimsIdentity)this.User.Identity;
                var claim = claimsIdentity.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier);
                var userId = claim.Value;
                announcement.UserID = userId;
                announcement.CreatedOn = DateTime.Now;
                _announcementService.AddAnnouncement(announcement);
                return RedirectToAction("Index");
            }
            return View();
        }

        [Authorize(Roles = "Teacher")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var announcement = _announcementService.GetAnnouncementById(id);

            if(announcement == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Not Found");
            }
      
            return View("Edit", announcement);
        }

        [Authorize(Roles = "Teacher")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([FromForm] Announcement announcement)
        {
            if (ModelState.IsValid)
            {
                _announcementService.EditAnnouncement(announcement);
                return RedirectToAction("Index");
            }
            return View();
        }

        [Authorize(Roles = "Teacher")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Announcement announcement = _announcementService.GetAnnouncementById(id);
            if (announcement == null)
            {
                return NotFound();
            }
            return View(announcement);
        }

        [Authorize(Roles = "Teacher")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int? id)
        {
            _announcementService.RemoveAnnouncement(id);

            return RedirectToAction("Index");

        }
    }
}
