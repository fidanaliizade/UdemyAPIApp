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
		
		private readonly IRegisterService _service;

		public AccountController(IRegisterService service)
		{
			_service = service;
		}

		
        [HttpPost]
		public async Task<IActionResult> Register([FromForm]RegisterDto registerDto)
		{
			await _service.Register(registerDto);
			return Ok();
		}

	}
}
