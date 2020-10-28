using DigiPro_ControlEscolar.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DigiPro_ControlEscolar.Controllers
{
    public class MyDbContext: IdentityDbContext<ApplicationUser>
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }

        public DbSet<Alumno> Alumno { get; set; }
        public DbSet<Materia> Materia { get; set; }
        public DbSet<DetAlumnosMaterias> DetAlumnosMaterias { get; set; }

    }
    public class Alumno {
        public int Id { get; set; }
        [StringLength(50)]
        public string Nombre { get; set; }
        [StringLength(50)]
        public string ApPaterno { get; set; }
        [StringLength(50)]
        public string ApMaterno { get; set; }
        public ICollection<DetAlumnosMaterias> AlumnosMaterias { get; set; }
       
        }

        public class Materia {
        public int Id { get; set; }
        [StringLength(50)]
        public string NombreMateria { get; set; }
        public Decimal Costo { get; set; }

        public ICollection<DetAlumnosMaterias> AlumnosMaterias { get; set; }

    }
        
        public class DetAlumnosMaterias
        {
        
            public int Id { get; set; }
            public int Alumnoid { get; set; }
            public Alumno Alumno { get; set; }
            public int Materiaid { get; set; }
            public Materia Materia { get; set; }
         
        }
        
    
}
