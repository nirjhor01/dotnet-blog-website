using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Application.CustomExceptions
{
  public class UserRegistrationException : ClientCustomException
  {
    public UserRegistrationException(
        string message,
        Dictionary<string, object>? errorData = null
    ) : base(message, errorData)
    {
    }
  }
}
