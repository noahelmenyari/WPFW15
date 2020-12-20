using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WPFW15.Models;

namespace WPFW15.Data
{
    public class WPFW15Context : DbContext
    {
        public WPFW15Context (DbContextOptions<WPFW15Context> options)
            : base(options)
        {
        }

        public DbSet<WPFW15.Models.Student> Student { get; set; }
    }
}
