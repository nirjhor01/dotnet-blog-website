using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Application.Dto.Request
{
  public class PostRequest
  {
    public string? Title { get; set; }
    public string? Content { get; set; }
  }
}
