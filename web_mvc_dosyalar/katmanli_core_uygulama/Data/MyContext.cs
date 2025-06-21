using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class MyContext:DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options) { 

        }
        public virtual DbSet<Kullanicilar> Kullanicilars  { get;set; }
        public virtual DbSet<Araclar> Araclars { get; set; }
        public virtual DbSet<AracTuru> AracTuru { get; set; }
    }
    
}
