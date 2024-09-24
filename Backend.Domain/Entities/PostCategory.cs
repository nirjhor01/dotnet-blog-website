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

    [ForeignKey("cat")]
    public int CategoryId { get; set; }
    //[ForeignKey("post")]
    public int PostId { get; set; }

    public Category cat { get; set; }
    public Post post { get; set; }

  }
}
