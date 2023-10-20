using MontecarloExamen.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontecarloExamen.Algoritmos
{
    public class AlgoritmoGenerador
    {
        public List<Experimentos> lista = new List<Experimentos>();

        public List<Experimentos> AlgoritmoMonteCarlo(int a1, int a2, int b1, int b2, int tamano, int limInf, int limSup)
        {
            List<Experimentos> listaSalida = new List<Experimentos>();

            Random random = new Random();

            for (int muestra = 0; muestra < tamano; muestra++)
            {
                listaSalida.Add(new Experimentos());
                listaSalida[muestra].Id = muestra;
                listaSalida[muestra].Posicion = muestra;
                listaSalida[muestra].ValorGenerado = random.NextDouble() * (limSup - limInf) + limInf;
                listaSalida[muestra].AlturaGenerada = Math.Abs(a1 * Math.Sin(b1 * listaSalida[muestra].ValorGenerado)
                    + a2 * Math.Cos(b2 * listaSalida[muestra].ValorGenerado));
                listaSalida[muestra].AreaGenerada = (((double)limSup - limInf) / tamano) * listaSalida[muestra].AlturaGenerada;
            }

            return listaSalida;

        }

        public double EstimacionIntegral(List<Experimentos> listaMuestras, int limInf, int limSup)
        {
            double sumaAreas = 0.0;
            double estimacion;

            for (int i = 0; i <  listaMuestras.Count; i++)
            {
                sumaAreas += listaMuestras[i].AreaGenerada;

            }

            estimacion = (limSup - limInf) * sumaAreas;

            return estimacion;
        }
    }
}
