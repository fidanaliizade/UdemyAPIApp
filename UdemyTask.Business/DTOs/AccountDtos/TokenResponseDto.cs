using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyTask.Business.DTOs.AccountDtos
{
    public record TokenResponseDto
    {
        public string Token { get; set; }
        public string Username { get; set; }
        public DateTime ExpireDate { get; set; }
    }
}
