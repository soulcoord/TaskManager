using Microsoft.AspNetCore.Mvc;
using TaskManager.Data;
using TaskManager.Models;

namespace TaskManager.Controllers
{
	public class TasksController : Controller
	{
		private readonly AppDbContext _db;

		// 建構子注入 DbContext（DI 會自動幫你塞進來）
		public TasksController(AppDbContext db)
		{
			_db = db;
		}

		// 1. 顯示所有任務
		public IActionResult Index()
		{
			var tasks = _db.Tasks.ToList(); // 從資料庫取出所有任務
			return View(tasks);             // 丟到 View 顯示
		}

		// 2. 顯示新增頁面
		public IActionResult Create()
		{
			return View();
		}

		// 3. 接收新增資料
		[HttpPost]
		public IActionResult Create(TaskItem task)
		{
			if (ModelState.IsValid) // 驗證通過才新增
			{
				_db.Tasks.Add(task);
				_db.SaveChanges();
				return RedirectToAction(nameof(Index)); // 回到清單
			}
			return View(task);
		}
	}
}
