using Microsoft.AspNetCore.Mvc;
using MyPortolioUdemy.DAL.Context;

namespace MyPortolioUdemy.ViewComponents.LayoutViewComponents
{
	public class _LayoutNavbarComponentPartial:ViewComponent
	{

		public IViewComponentResult Invoke()
		{

			return View();
		}
	}
}
