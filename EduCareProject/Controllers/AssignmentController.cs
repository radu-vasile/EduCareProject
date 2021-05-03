using EduCareProject.Models;
using EduCareProject.Services;
using EduCareProject.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduCareProject.Controllers
{
    public class AssignmentController : Controller
    {
        public readonly IAssignmentService _assignmentsService;

        public AssignmentController(IAssignmentService assignmentService)
        {

            _assignmentsService = assignmentService;

        }
        public ActionResult Index()
        {
            var assignments = _assignmentsService.GetAllAssignments();
            return View(assignments);
        }

        // GET: HomeController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }        
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] Assignment assignment)
        {
            if (ModelState.IsValid)
            {
                _assignmentsService.AddNewAssignment(assignment);
                return RedirectToAction("CreateQuestions", new { assignment.Id});
            }
            return View("Index");

        }
        [HttpGet]
        public ActionResult CreateQuestions(int id)
        {

            return View(new Question { AssignmentId = id });
        }

        [HttpPost]
        public ActionResult CreateQuestions(Question question, bool redirectToNewForm)
        {
            if (ModelState.IsValid)
            {
                _assignmentsService.AddNewQuestion(question);
                if (redirectToNewForm) {
                    return Json(Url.Action("Index"));
                }
                return Json(Url.Action("CreateQuestions", "Assignment", new Question { AssignmentId = question.AssignmentId}));
            }
            return View("Index");
        }

        // GET: HomeController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HomeController1/Edit/5
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

        // GET: HomeController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HomeController1/Delete/5
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

        [HttpGet]
        public ActionResult Solve(int id)
        {
            var questions = _assignmentsService.GetAllQuestionsByAssignmentId(id);

            return View(questions.ToList());
        }
    }
}
