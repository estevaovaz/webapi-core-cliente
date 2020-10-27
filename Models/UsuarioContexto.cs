using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiUnimed.Models
{
    public class UsuarioContexto : DbContext
    {
        public UsuarioContexto(DbContextOptions<UsuarioContexto> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuario { get; set; }

    }
}
