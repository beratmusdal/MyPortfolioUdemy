using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUdemy.Controllers
{
	public class MessageController : Controller
	{
		public IActionResult Inbox()
		{
			return View();
		}
	}
}
