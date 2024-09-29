using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Application.Dto.Response
{
  public class CategoryResponse
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Route { get; set; }
    public int Createdby { get; set; }
  }
}
