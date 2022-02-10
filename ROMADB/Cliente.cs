using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROMADB
{
    public class Cliente
    {
        public String Telefono { get; set; }
        public string Nombre { get; set; }
        public string Calle { get; set; }
        public string Colonia { get; set; }
        public string Municipio { get; set; }
        public string Referencia { get; set; }

        public Cliente() { }

        public Cliente(string pTelefono, string pNombre, string pCalle, string pColonia, string pMunicipio, string pReferencia)

        {

            this.Telefono = pTelefono;
            this.Nombre = pNombre;
            this.Calle = pCalle;
            this.Colonia = pColonia;
            this.Municipio = pMunicipio;
            this.Referencia = pReferencia;

        }
    }
}
