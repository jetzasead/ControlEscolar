using Microsoft.AspNetCore.Identity;

namespace DigiPro_ControlEscolar.Entities
{
    public class ApplicationUser:IdentityUser
    {
        public string Nombre { get; set; }
        public string ApPaterno { get; set; }
        public string ApMaterno { get; set; }
    }
}
