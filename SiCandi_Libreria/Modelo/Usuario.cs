using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiCandi_Libreria.Modelo
{
    [Table(name: "Usuarios")]
   public class Usuario
    {
        [Key]
        public int pkUsuario { get; set; }

      public int iNoEmpleado { get; set; }
        public String sContrasena { get; set; }
        public bool bStatus { get; set; }
        public virtual Rol fkRol { get; set; }
        public ICollection<Candidata> Candidatas { get; set; }

        public Usuario()
        {
            this.bStatus = true;
        }
    }
}
