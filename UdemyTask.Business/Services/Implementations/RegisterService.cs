using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyTask.Business.DTOs.AccountDtos;
using UdemyTask.Business.Services.Interfaces;
using UdemyTask.Core.Entities;

namespace UdemyTask.Business.Services.Implementations
{
	public class RegisterService : IRegisterService
	{
		private readonly UserManager<AppUser> _usermanager;

		public RegisterService(UserManager<AppUser>usermanager)
        {
			_usermanager = usermanager;
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
	}
}
