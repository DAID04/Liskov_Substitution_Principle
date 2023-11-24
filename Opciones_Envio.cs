using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tallerTerceraLetra
{
    internal interface OpcionesEnvio
    {
        public void SentEmail()
        {
            Console.WriteLine("Enviando por email...");
        }

        public void SentFax()
        {
            Console.WriteLine("Enviando por fax...");
        }
    }
}