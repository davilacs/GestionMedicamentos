using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMedicamentos
{
    struct Medicamento
    {
        //Nonbre Equipo Squad2
        public string s_codigo {  get; set; }
        public string s_nombre { get; set; }
        public int s_cantidad { get; set; }
        public float s_precioUnit { get; set; }

        //Creamos el constructor de Medicamento
        public Medicamento(string s_codigo, string s_nombre, int s_cantidad, float s_precioUnit)
        {
            this.s_codigo = s_codigo;
            this.s_nombre = s_nombre;
            this.s_cantidad= s_cantidad;
            this.s_precioUnit = s_precioUnit;
        }
    }
   
}
