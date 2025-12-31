using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using quiz1.Models.Entity;

public class QuizController : Controller
{
    private readonly ApplicationDbContext _context;

    public QuizController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(QuizQuestion question)
    {
        if (ModelState.IsValid)
        {
            _context.Add(question);  // Add the new question to the context
            await _context.SaveChangesAsync();  // Save to database
            return RedirectToAction(nameof(Index));  // Redirect to the index view
        }
        return View(question);
    }

    // GET: Quiz
    public IActionResult Index()
    {
        var questions = _context.QuizQuestions.ToList();
        return View(questions);
    }



    // GET: Quiz/Delete/5
    public IActionResult Delete(int id)
    {
        var question = _context.QuizQuestions.Find(id);
        if (question == null)
        {
            return NotFound();
        }
        return View(question);
    }

    // POST: Quiz/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteConfirmed(int id)
    {
        var question = _context.QuizQuestions.Find(id);
        _context.QuizQuestions.Remove(question);
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

  
}



 

