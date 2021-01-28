using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trivia.Services;
using Trivia.Models;

namespace Trivia.Controllers
{
    public class QuestionController : Controller
    {
        private readonly TriviaService triviaService;

        public QuestionController(TriviaService triviaService)
        {
            this.triviaService = triviaService;
        }


        // GET: TriviaController
        public ActionResult Index()
        {
            return View(triviaService.GetTriviaQuestion());
        }

        [HttpPost]
        [ActionName("getquestion")]
        public PartialViewResult GetQuestion()
        {
            return PartialView("~/Views/Shared/_Question.cshtml", triviaService.GetTriviaQuestion());
        }




 
        // GET: TriviaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TriviaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TriviaController/Create
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

        // GET: TriviaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TriviaController/Edit/5
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

        // GET: TriviaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TriviaController/Delete/5
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
