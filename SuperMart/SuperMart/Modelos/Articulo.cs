using SuperMart.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMart.Modelos
{
     public class Articulo
     {
            public string _nombre;

            public categoria _categoria;


        public Articulo (string nombre,categoria categoria)
            {
                _nombre = nombre;
            }

            public string Nombre => _nombre;
            public categoria Categoria => _categoria;
     }

   
}
