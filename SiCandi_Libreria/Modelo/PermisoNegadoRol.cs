using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiCandi_Libreria.Modelo
{
    [Table(name: "PermisosNegadosRol")]
  public class PermisoNegadoRol
    {
        [Key]
        public int pkPermisoNegadoRol { get; set; }


        public virtual Permiso fkPrmiso { get; set; }
       
        public virtual Rol fkRol { get; set; }
    }
}
