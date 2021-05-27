using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CodeProdigee.Api.Data
{
    public class CodeProdigeeContext : DbContext
    {
        public CodeProdigeeContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}
