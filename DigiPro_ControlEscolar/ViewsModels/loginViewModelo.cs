using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DigiPro_ControlEscolar.ViewsModels
{
    public class loginViewModelo
    {
        [BindProperty]
        public  InputModel Input {get; set; }
        [TempData]
        public string MensajeError { get; set; }
        public class InputModel
        {

            [Required(ErrorMessage = "<font color='red'> El campo Nombre es Obligatorio.</font>")]
            public string Nombre { get; set; }

            [Required(ErrorMessage = "<font color='red'> El campo Apellido es Obligatorio.</font>")]
            public string Apellido { get; set; }
        }
    }
}
