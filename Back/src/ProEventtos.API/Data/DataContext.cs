using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProEventtos.API.Models;

namespace ProEventtos.API.Data
{
    public class DataContext : DbContext    
    {
        public DataContext(DbContextOptions<DataContext> options ) : base(options) { }
        public DbSet<Eventto> Eventtos { get; set; }
    }
}