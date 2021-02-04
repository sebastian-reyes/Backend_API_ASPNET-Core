using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Login_CRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Login_CRUD.Context
{
    public class BDProductosContext : DbContext
    {
        public BDProductosContext(DbContextOptions<BDProductosContext> options) : base(options)
        {
            
        }
        public DbSet<Usuario> usuarios { get; set; } 
    }
}
