using Backend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Application.Dto.Response
{
  public class PostResponse : BaseEntity
  {
    public string? Title { get; set; }
    public string? Content { get; set; }
  }
}
