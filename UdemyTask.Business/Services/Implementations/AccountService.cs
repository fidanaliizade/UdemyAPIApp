using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyTask.Business.DTOs.AccountDtos;
using UdemyTask.Business.Exceptions.User;
using UdemyTask.Business.ExternalServices.Interfaces;
using UdemyTask.Business.Services.Interfaces;
using UdemyTask.Core.Entities;

namespace UdemyTask.Business.Services.Implementations
{
	public class AccountService : IAccountService
	{
		private readonly UserManager<AppUser> _usermanager;
        private readonly ITokenService _tokenService;

        public AccountService(UserManager<AppUser>usermanager, ITokenService tokenService)
        {
			_usermanager = usermanager;
            _tokenService = tokenService;
        }

     

        public async Task Register(RegisterDto registerdto)
		{
			AppUser user = new AppUser()
			{
				Name = registerdto.Name,
				Email = registerdto.Email,
				Surname = registerdto.Surname,
				UserName = registerdto.Username
			};
		   var result = await _usermanager.CreateAsync(user, registerdto.Password);
			if(!result.Succeeded)
			{
                foreach (var item in result.Errors)
                {
					return;
                }
            }

		}
        public async Task<TokenResponseDto> LoginAsync(LoginDto logindto)
        {
			var user = await _usermanager.FindByNameAsync(logindto.UsernameOrEmail) ?? await  _usermanager.FindByNameAsync(logindto.UsernameOrEmail);
			if (user == null) throw new UserNotFoundException();
			if(!await _usermanager.CheckPasswordAsync(user,logindto.Password)) throw new Exception();
			return _tokenService.CreateToken(user, 45);
		}
    }
}
