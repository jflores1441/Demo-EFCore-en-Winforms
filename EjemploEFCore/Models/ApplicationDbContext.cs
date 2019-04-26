using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploEFCore.Models
{
    class ApplicationDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsbuilder)
        {
            optionsbuilder.UseSqlServer("Data Source=.;Initial Catalog= demoCore; Integrated Security= true; User Id=sa;Password=admin123.")
                .EnableSensitiveDataLogging(true)
                .UseLoggerFactory(new LoggerFactory().AddConsole((category, level) => level == LogLevel.Information && category == DbLoggerCategory.Database.Command.Name, true));
        }

        //Método que indica a EF core que se generara una tabla con el nombre Estudiantes
        public DbSet<Estudiante> Estudiantes { get; set; }
    }
}
