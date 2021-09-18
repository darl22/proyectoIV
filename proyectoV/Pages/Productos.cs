using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using proyectoV;

namespace proyectoV.Pages
{


    public class Productos
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public Categoria categoria { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public double precio { get; set; }


        List<Productos> product;

        public Productos()
        {
            product = new List<Productos>()
            {

                new Productos() { id = 001, nombre = "Lapto i7l", marca = "Lenovo", modelo = "idealpal", precio = 24000 },
                new Productos() { id = 001, nombre = "Impresora", marca = "HP", modelo = "HT100", precio = 4000 },
                new Productos() { id = 001, nombre = "Celular", marca = "SAMSUM", modelo = "S9", precio = 14000 },
                new Productos() { id = 001, nombre = "Televisor", marca = "SAMSUM", modelo = "NONE", precio = 24000 },
                new Productos() { id = 001, nombre = "Monito", marca = "DELL", modelo = "lcp12", precio = 2000 },
                new Productos() { id = 001, nombre = "mause", marca = "Xtrike", modelo = "Gm-106", precio = 1500 },
                new Productos() { id = 001, nombre = "pantalla", marca = "SAMSUM", modelo = "xd20", precio = 1200 },
                new Productos() { id = 001, nombre = "cargardores", marca = "iphone", modelo = "Tg100", precio = 1000 },
                new Productos() { id = 001, nombre = "moderboard", marca = "IBM", modelo = "Fdr-123", precio = 24000 },
                new Productos() { id = 001, nombre = "powersuppli", marca = "IBM", modelo = "", precio = 24000 }


                };
        }

      

    }
}

