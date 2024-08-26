using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace EjeDrive.Algoritmos
{
    internal class AlgoritmoSimulacion
    {

        public AlgoritmoSimulacion() { }
        public List<int> GenerarValores(int n)
        {
            List<int> listaSalida = new List<int>();
            for (int i = 0; i < n; i++)
            {
                listaSalida.Add(5*(i+1));
            }

            return listaSalida;

        }

        public List<int> GeneradorCongruencial(int a, int c, int m, int x0)
        {
            List<int> listaSalida = new List<int>();

            bool entra = true;
            int xi = x0;

            while (entra)
            {
                xi = (a*xi + c) % m;

                if (!listaSalida.Contains(xi))
                {
                    listaSalida.Add((xi + 1) % m);
                }

                else
                {
                    entra = false;
                }
                
            }

           

            return listaSalida;

        }

    }
}
