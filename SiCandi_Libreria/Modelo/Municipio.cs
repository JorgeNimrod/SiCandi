using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiCandi_Libreria.Modelo
{
    [Table(name: "Municipios")]
    public class Municipio
    {
        [Key]
        public int pkMunicipio { get; set; }

       
        public String sMunicipio { get; set; }
        public String sLogotipo { get; set; }
        public bool bStatus { get; set; }

        public ICollection<Candidata> Candidatas { get; set; }
        public Municipio()
        {
            bStatus = true;
        }
    }
}
