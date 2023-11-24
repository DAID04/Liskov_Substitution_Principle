using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tallerTerceraLetra
{
    internal interface OpcionesEscaneo
    {
        public void Scan()
        {
            Console.WriteLine("Escaneando...");
        }
    }
}