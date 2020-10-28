using DigiPro_ControlEscolar.Controllers;
using System.Collections.Generic;

namespace DigiPro_ControlEscolar.Models
{
    public class CreateAlumno
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string ApPaterno { get; set; }
        public string ApMaterno { get; set; }

        public List<Materia> Materias { get; set; }

        public CreateAlumno()
        {
            Materias = new List<Materia>();
        }

    }
}
