using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Backend.Domain.Entities
{
  [Table("Category", Schema = "dbo")]
  //[Index("Name", IsUnique = true, = "Category_Route")]
  public class Category
  {
    public Category()
    {
      PostCategories = new HashSet<PostCategory>();
    }
    [Key]
    public int Id { get; set; }
    public string? Name { get; set; }
    public virtual ICollection<PostCategory> PostCategories { get; set; }
  }
}
