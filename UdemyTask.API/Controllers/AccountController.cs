using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyTask.Business.DTOs.AccountDtos;
using UdemyTask.Business.Services.Interfaces;
using UdemyTask.DAL.Context;

namespace UdemyTask.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AccountController : ControllerBase
	{
		
		private readonly IAccountService _service;

		public AccountController(IAccountService service)
		{
			_service = service;
		}

		
        [HttpPost]
		public async Task<IActionResult> Register([FromForm]RegisterDto registerDto)
		{
			await _service.Register(registerDto);
			return Ok();
		}

		[HttpPost("(action)")]
		public async Task<IActionResult> Login([FromForm] LoginDto loginDto)
		{
			var result = await _service.LoginAsync(loginDto);
			return Ok(result);
		}

	}
}
