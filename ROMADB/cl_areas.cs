﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROMADB
{
    class cl_areas
    {
        private string nombre;
        private string ubicacion;

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public string Ubicacion
        {
            get
            {
                return ubicacion;
            }
            set
            {
                ubicacion = value;
            }
        }
    }
}
