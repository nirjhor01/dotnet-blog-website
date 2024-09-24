using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Domain.Entities
{
  [Table("Category", Schema = "dbo")]
  public class Post
  {
    public int Id { get; set; }
    public string? Title {  get; set; }
    public string? Route { get; set; }
    public string? Content {  get; set; }
    public ICollection<PostCategory> PostCategories { get; set; }
    
  }
}
