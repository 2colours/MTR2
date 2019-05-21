using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MTR2.Dal.Entities;

namespace MTR2.Web.Pages.Account
{
	public class LoginModel : PageModel
	{
		private SignInManager<User> SignInManager { get; }
		private UserManager<User> UserManager { get; }
		public LoginModel(SignInManager<User> signInManager, UserManager<User> userManager)
		{
			SignInManager = signInManager;
			UserManager = userManager;
		}

		public class InputModel
		{
			[Display(Name = "Felhasználónév"), Required(ErrorMessage = "A felhasználónév megadása		   kötelező")]
			public string UserName { get; set; }
			[Display(Name = "Jelszó"), Required(ErrorMessage = "A jelszó megadása kötelező"), DataType(DataType.Password)]
			public string Password { get; set; }
			[Display(Name = "Maradjak belépve")]
			public bool KeepMeSignedIn { get; set; }
		}

		[BindProperty]
		public InputModel Input { get; set; }
		public ActionResult OnGet()
		{
			if (User.Identity.IsAuthenticated)
				return RedirectToPage("/Index");
			return Page();
		}

		public async Task<ActionResult> OnPost()
		{
			if (ModelState.IsValid)
			{
				var signInResult = await SignInManager.PasswordSignInAsync(Input.UserName, Input.Password, Input.KeepMeSignedIn, false);
				if (!signInResult.Succeeded)
					ModelState.AddModelError("", "Sikertelen bejelentkezési kísérlet.");
				else
					return RedirectToPage("/Index");
			}
			return Page();
		}
		public IActionResult OnPostMicrosoftLogin()
		{
			return Challenge(SignInManager.ConfigureExternalAuthenticationProperties("Microsoft", Url.Page("./Login", "MicrosoftCallback")), "Microsoft");
		}
		public async Task<IActionResult> OnGetMicrosoftCallbackAsync(string returnUrl = null, string remoteError = null)
		{
			if (remoteError != null)
				return Error(new[] { remoteError });
			var info = await SignInManager.GetExternalLoginInfoAsync();
			if (info == null)
				return RedirectToPage("./Login");
			var result = await SignInManager.ExternalLoginSignInAsync(info.LoginProvider, info.ProviderKey, isPersistent: false, bypassTwoFactor: true);
			if (!result.Succeeded) {
				var email = info.Principal.FindFirstValue(ClaimTypes.Email);
				var user = new User { UserName = email, Email = email, SecurityStamp = Guid.NewGuid().ToString() };
				var createUserResult = await UserManager.CreateAsync(user);
				if (createUserResult.Succeeded)
					return Error(createUserResult.Errors.Select(e => e.Description));
				await SignInManager.SignInAsync(user, false);
			}
			return RedirectToPage("/Index");
		}

		private IActionResult Error(IEnumerable<string> errors)
		{
			foreach (var error in errors)
			{
				ModelState.AddModelError("", error);
			}
			return Page();
		}
	}
}