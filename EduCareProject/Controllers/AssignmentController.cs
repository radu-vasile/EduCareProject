using EduCareProject.Models;
using EduCareProject.Services;
using EduCareProject.ViewModels;
using Microsoft.AspNetCore.Authorization;
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
        [Authorize(Roles = "Student, Teacher")]
        public ActionResult Index()
        {
            var assignments = _assignmentsService.GetAllAssignments();
            return View(assignments);
        }


        [Authorize(Roles = "Teacher")]
        public ActionResult Create()
        {
            return View();
        }

        [Authorize(Roles = "Teacher")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] Assignment assignment)
        {
            if (ModelState.IsValid)
            {
                assignment.CreatedOn = DateTime.Now;
                _assignmentsService.AddNewAssignment(assignment);
                return RedirectToAction("CreateQuestions", new { _assignmentId = assignment.Id , _currentQuestionNumber = 1, _totalNumberOfQuestions = assignment.NumberOfQuestions});
            }
            return View();
        }

        [Authorize(Roles = "Teacher")]
        [HttpGet]
        public ActionResult CreateQuestions(int _assignmentId, int _currentQuestionNumber, int _totalNumberOfQuestions)
        {
            var _question = new Question { 
                AssignmentId = _assignmentId
            };
            var _qa = new QuestionAssignmentViewModel { 
                currentQuestionNumber = _currentQuestionNumber, 
                question = _question, 
                totalNumberOfQuestions = _totalNumberOfQuestions 
            };
            return View(_qa);
        }

        [Authorize(Roles = "Teacher")]
        [HttpPost]
        public ActionResult CreateQuestions(QuestionAssignmentViewModel qa, bool redirectToNewForm)
        {
            if (ModelState.IsValid)
            {
                _assignmentsService.AddNewQuestion(qa.question);
                if(qa.totalNumberOfQuestions == qa.currentQuestionNumber)
                {
                    return View("AssignmentCreated");
                }
                else
                {
                    var _qa = new QuestionAssignmentViewModel
                    {
                        currentQuestionNumber = qa.currentQuestionNumber+1,
                        question = new Question { AssignmentId = qa.question.AssignmentId},
                        totalNumberOfQuestions = qa.totalNumberOfQuestions
                    };
                    return RedirectToAction("CreateQuestions", new { _assignmentId = _qa.question.AssignmentId, _currentQuestionNumber = _qa.currentQuestionNumber, _totalNumberOfQuestions = _qa.totalNumberOfQuestions });
                }
            }
            return View(qa);
        }

        [HttpGet]
        public ActionResult Solve(int id)
        {
            var questions = _assignmentsService.GetAllQuestionsByAssignmentId(id);

            return View(questions.ToList());
        }
        [Authorize(Roles = "Teacher")]
        public ActionResult Delete(int id)
        {

            _assignmentsService.DeleteAssignment(id);
            return RedirectToAction("Index");

        }
    }
}
