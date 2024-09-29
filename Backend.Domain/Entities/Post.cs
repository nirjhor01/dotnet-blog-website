using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Domain.Entities
{
  [Table("Post", Schema = "dbo")]
  public class Post
  {
    public Post()
    {
      PostCategories = new HashSet<PostCategory>();
    }
    [Key]
    public int Id { get; set; }
    public string? Title {  get; set; }
    public string? Route { get; set; }
    public string? Content {  get; set; }
    public virtual ICollection<PostCategory> PostCategories { get; set; }
    
  }
}
