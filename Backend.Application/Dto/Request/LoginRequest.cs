using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Application.Dto.Request
{
  public class LoginRequest
  {
    [EmailAddress]
    public string Email { get; set; }
    public string Password { get; set; }
  }
}
