using AutoMapper;
using Backend.Application.Dto.Request;
using Backend.Domain.Entities;

namespace BackendTemplate.Mappers
{
  public class RequestMapper: Profile
  {
    public RequestMapper()
    {
      CreateMap<UserRequest, User>();
      CreateMap<CategoryRequest, Category>();
    }
  }
}
