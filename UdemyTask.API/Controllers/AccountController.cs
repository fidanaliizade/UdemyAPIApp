using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyTask.Business.DTOs.AccountDtos;

namespace UdemyTask.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AccountController : ControllerBase
	{
		public IActionResult Register()
		{
			return Ok();
		}
		[HttpPost]
		public async Task<IActionResult> Register(RegisterDto registerDto)
		{
			if (!ModelState.IsValid)
			{
				return Ok();
			}
			return Ok();
		}

	}
}
