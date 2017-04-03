using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiCandi_Libreria.Modelo
{
    [Table(name: "Roles")]
    public class Rol
    {
        [Key]
        public int pkUsuario { get; set; }

        public int iNoEmpleado { get; set; }
        public String sContrasena { get; set; }
        public bool bStatus { get; set; }
        public ICollection<Usuario> Usuarios { get; set; }
        public ICollection<PermisoNegadoRol> PermisosNegadosRol { get; set; }
        public Rol()
        {
            bStatus = true;
        }
    }
}
