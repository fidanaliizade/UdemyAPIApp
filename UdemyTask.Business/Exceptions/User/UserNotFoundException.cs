using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyTask.Business.Exceptions.User
{
    public class UserNotFoundException:Exception
    {
        public UserNotFoundException() : base("Username/Email or Password is wrong!") { }
        public UserNotFoundException(string? message): base(message)
        {
            
        }

    }
}
