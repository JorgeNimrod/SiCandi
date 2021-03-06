﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiCandi_Libreria.Modelo
{
    [Table(name: "Permisos")]
     public class Permiso
    {
        [Key]
        public int pkPermiso { get; set; }


        public String sModulo { get; set; }
        public String sDescripcion  { get; set; }

        public ICollection<PermisoNegadoRol> PermisosNegadosRol { get; set; }

    }
}
