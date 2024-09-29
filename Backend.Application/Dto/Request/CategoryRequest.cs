using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Backend.Application.Dto.Request
{
  public class CategoryRequest
  {
    public string Name { get; set; }

    public string Route
    {
      get
      {
        var name = Name.ToLowerInvariant();

        // Replace any character that is not a letter, number, space, or dash.
        // This regex is modified to allow Unicode letters (for Bengali and other scripts).
        name = Regex.Replace(name, @"[^\p{L}\p{N}\s-]", "");

        // Replace multiple spaces with a single space
        name = Regex.Replace(name, @"\s+", " ").Trim();

        // Replace spaces with dashes
        name = name.Replace(" ", "-");

        return name;
      }
    }
  }
}
