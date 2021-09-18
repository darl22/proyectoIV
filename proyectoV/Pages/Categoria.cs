using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proyectoV.Pages
{
    public class Categoria
    {
        public int id { get; set; }
        public String nombre { get; set; }

        public enum categorias
        {
            None,
            Electronic,
            Computer,
            Hardware,
            Software

        }
    } 
}
