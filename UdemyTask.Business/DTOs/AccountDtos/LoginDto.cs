using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyTask.Business.DTOs.AccountDtos
{
    public record LoginDto
    {
        public string UsernameOrEmail { get; set; }
        public string Password { get; set; }
    }

    public class LoginDtoValidation : AbstractValidator<LoginDto>
    {
        public LoginDtoValidation()
        {
            RuleFor(l=>l.UsernameOrEmail)
                .NotEmpty()
                .WithMessage("UserName Or Email shouldn't be empty.");
            RuleFor(l => l.Password)
                .NotEmpty()
                .WithMessage("Password shouldn't be empty.");
        }

    }
}
