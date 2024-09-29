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
    #region Login
    Task<UserLoginResponse> Login(LoginRequest loginRequest);
    #endregion Login

    #region Save
    Task<UserResponse> Register(UserRequest request);
    #endregion Save
  }
}
