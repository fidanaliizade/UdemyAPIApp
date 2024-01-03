using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyTask.Business.DTOs.AccountDtos;
using UdemyTask.Core.Entities;

namespace UdemyTask.Business.ExternalServices.Interfaces
{
    public interface ITokenService
    {
        TokenResponseDto CreateToken(AppUser user, int expiredate);
    }
}
