using System.Linq;
using System.Threading.Tasks;
using FrontToBackSqlConnection.Data;
using FrontToBackSqlConnection.Models;
using Microsoft.AspNetCore.Mvc;


namespace FrontToBackSqlConnection.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        private object home;

        public ActionResult(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var students = await _context.Home.ToListAsync();
            return View(students);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var student = await _context.Home.FirstOrDefaultAsync(m => m.Id == id);
            if (student == null)
                return NotFound();

            return View(student);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create()
        {
            if (!ModelState.IsValid)
                return View(home);

            _context.Add(home);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private IActionResult View(object home)
        {
            throw new NotImplementedException();
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var student = await _context.FindAsync(id);
            if (student == null)
                return NotFound();

            return View(student);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Student home)
        {
            if (id != home.Id)
                return NotFound();

            if (!ModelState.IsValid)
                return View(home);

            try
            {
                _context.Update(home);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Home.Any(e => e.Id == home.Id))
                    return NotFound();
                else
                    throw;
            }

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var student = await _context.Home.FirstOrDefaultAsync(m => m.Id == id);
            if (student == null)
                return NotFound();

            return View(student);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var student = await _context.Home.FindAsync(id);
            if (student != null)
            {
                _context.Home.Remove(student);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }
    }
}