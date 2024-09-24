using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Data
{
    public partial class EFDbContext:DbContext
    {

    public EFDbContext()
    {
        
    }
    public EFDbContext(DbContextOptions<EFDbContext> options) : base(options)
    {

    }

  }
}
