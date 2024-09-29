using AutoMapper;
using Backend.Application.Dto.Request;
using Backend.Application.Dto.Response;
using Backend.Domain.Entities;

namespace BackendTemplate.Mappers
{
  public class ResponseMapper:Profile
  {
    public ResponseMapper()
    {
      CreateMap<User, UserResponse>();
      CreateMap<User, UserLoginResponse>();
      CreateMap<Category, CategoryResponse>();
    }
  }
}
