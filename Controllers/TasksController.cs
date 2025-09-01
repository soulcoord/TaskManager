using Microsoft.AspNetCore.Mvc;
using TaskManager.Data;
using TaskManager.Models;

namespace TaskManager.Controllers
{
	public class TasksController : Controller
	{
		private readonly AppDbContext _db;

		public TasksController(AppDbContext db)
		{
			_db = db;
		}

		public IActionResult Index()
		{
			var tasks = _db.Tasks.ToList();
			return View(tasks);
		}


		public IActionResult Create()
		{
			return View();
		}

	
		[HttpPost]
		public IActionResult Create(TaskItem task)
		{
			if (ModelState.IsValid)
			{
				_db.Tasks.Add(task);
				_db.SaveChanges();
				return RedirectToAction(nameof(Index));
			}
			return View(task);
		}
	}
}
