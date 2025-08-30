using Microsoft.AspNetCore.Mvc;
using TaskManager.Data;
using TaskManager.Models;

namespace TaskManager.Controllers
{
	public class TasksController : Controller
	{
		private readonly AppDbContext _db;

		// ������ע�� DbContext��DI ���Ԅӎ������M��
		public TasksController(AppDbContext db)
		{
			_db = db;
		}

		// 1. �@ʾ�����΄�
		public IActionResult Index()
		{
			var tasks = _db.Tasks.ToList(); // ���Y�ώ�ȡ�������΄�
			return View(tasks);             // �G�� View �@ʾ
		}

		// 2. �@ʾ�������
		public IActionResult Create()
		{
			return View();
		}

		// 3. ���������Y��
		[HttpPost]
		public IActionResult Create(TaskItem task)
		{
			if (ModelState.IsValid) // ��Cͨ�^������
			{
				_db.Tasks.Add(task);
				_db.SaveChanges();
				return RedirectToAction(nameof(Index)); // �ص����
			}
			return View(task);
		}
	}
}
