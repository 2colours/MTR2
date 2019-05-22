using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MTR2.Web.Controllers
{
	[Route("[controller]/[action]")]
	public class PreviewModeController : Controller
	{
		private void SetCookie(string key, string value, int? expireTime = null)
		{
			CookieOptions option = new CookieOptions();
			if (expireTime.HasValue)
				option.Expires = DateTime.Now.AddMinutes(expireTime.Value);
			else
				option.Expires = DateTime.MaxValue;
			Response.Cookies.Append(key, value, option);
		}

		public IActionResult ModeUser()
		{
			SetCookie("preview", nameof(ModeUser));
			return RedirectToPage("/Repo");
		}

		public IActionResult ModeAdmin()
		{
			SetCookie("preview", nameof(ModeAdmin));
			return RedirectToPage("/Repo");
		}
	}
}
