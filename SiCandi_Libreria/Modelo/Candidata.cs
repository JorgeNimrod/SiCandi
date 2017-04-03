using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiCandi_Libreria.Modelo
{
    [Table(name: "Candidatas")]
     public class Candidata
    {
        [Key]
        public int pkCandida { get; set; }

        public DateTime dAnioConvocatoria { get; set; }
        public String sNombreCompleto { get; set; }
        public DateTime dFechaNacimiento { get; set; }
        public String sDescripcion { get; set; }
        
        public virtual Municipio fkMunicipio { get; set; }
        public virtual Usuario fkUsuario { get; set; }
        public String sEmail { get; set; }
        public String sCurp { get; set; }
        public String sFotografia { get; set; }
        public int iLike { get; set; }

        public bool bStatus { get; set; }

        public Candidata()
        {
            this.bStatus = true;
        }






    }
}
