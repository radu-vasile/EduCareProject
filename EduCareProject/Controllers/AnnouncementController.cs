using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EduCareProject.Models;
using EduCareProject.Services;
using System.Net;

namespace EduCareProject.Controllers
{
    public class AnnouncementController : Controller
    {

        public readonly IAnnouncementService _announcementService;

        public AnnouncementController(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
        }

        public ActionResult Index()
        {
            var announcements = _announcementService.GetAnnouncements();
            return View("Index", announcements);
        }


        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] Announcement announcement)
        {
            if(ModelState.IsValid)
            {
                announcement.CreatedOn = DateTime.Now;
                _announcementService.AddAnnouncement(announcement);
                return RedirectToAction("Index");
            }
            return View();
        }


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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([FromForm] Announcement announcement)
        {
            if (ModelState.IsValid)
            {
                _announcementService.EditAnnouncement(announcement);
                return RedirectToAction("Index");
            }
            return BadRequest();
        }

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

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int? id)
        {
            _announcementService.RemoveAnnouncement(id);

            return RedirectToAction("Index");

        }
    }
}
