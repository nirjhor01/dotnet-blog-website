using Backend.Application.Dto.Request;
using Backend.Application.Dto.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Application.Interfaces.Auth
{
  public interface IAuthService
  {
    Task<UserLoginResponse> Login(LoginRequest loginRequest);

    #region Save
    Task<UserLoginResponse> Register(UserRequest request);
    #endregion Save
  }
}
