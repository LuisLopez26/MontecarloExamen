using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontecarloExamen.Modelos
{
    public class Experimentos
    {
        public int Id {  get; set; }
        public int Posicion { get; set; }

        public double ValorGenerado { get; set; }
        public double AlturaGenerada { get; set; }
        public double AreaGenerada { get; set; }

        public Experimentos() { }

        public Experimentos(int id, int posicion, double valorGenerado, double alturaGenerada, double areaGenerada)
        {
            Id = id;
            Posicion = posicion;
            ValorGenerado = valorGenerado;
            AlturaGenerada = alturaGenerada;
            AreaGenerada = areaGenerada;
        }
    }
}
