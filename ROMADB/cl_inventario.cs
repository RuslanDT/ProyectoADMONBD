using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROMADB
{
    public class cl_inventario
    {
        private int id_inventario;
        private string nombre_corto;
        private string descripcion;
        private string serie;
        private string color;
        private string fecha_adquisicion;
        private string tipo_adquisicion;
        private string observaciones;
        private int id_areas;

        public int Id_inventario
        {
            get
            {
                return id_inventario;
            }
            set
            {
                id_inventario = value;
            }
        }
        public string Nombre_corto
        {
            get{
                return nombre_corto;
            }
            set{
                nombre_corto = value;
            }
        }
        public string Descripcion
        {
            get
            {
                return descripcion;
            }
            set
            {
                descripcion = value;
            }
        }
        public string Serie
        {
            get
            {
                return serie;
            }
            set
            {
                serie = value;
            }
        }
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }
        public string Fecha_adquisicion
        {
            get
            {
                return fecha_adquisicion;
            }
            set
            {
                fecha_adquisicion = value;
            }
        }
        public string Tipo_adquisicion
        {
            get
            {
                return tipo_adquisicion;
            }
            set
            {
                tipo_adquisicion = value;
            }
        }
        public string Observaciones
        {
            get
            {
                return observaciones;
            }
            set
            {
                observaciones = value;
            }
        }
        public int Id_areas
        {
            get
            {
                return id_areas;
            }
            set
            {
                id_areas = value;
            }
        }
    }
}
