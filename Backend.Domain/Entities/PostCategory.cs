using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Domain.Entities
{
  public class PostCategory
  {
    [Key]
    [Column("Id")]
    public int Id { get; set; }

    [ForeignKey("Category")]
    public int CategoryId { get; set; }
    [ForeignKey("Post")]
    public int PostId { get; set; }

    public Category Category { get; set; }
    public Post Post { get; set; }

  }
}
