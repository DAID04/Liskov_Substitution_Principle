using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tallerTerceraLetra
{
    internal interface OpcionesLectura
    {
        public void Print() //
        {
            Console.WriteLine("Imrpimiendo...");
        }
        public void Photocopy() //
        {
            Console.WriteLine("Copiando...");
        }
        public void Cancel() //
        {
            Console.WriteLine("Cancelado.");
        }
    }
}