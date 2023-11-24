using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle
{
    internal class Ejecutar
    {
        static void EjecutarMenu()
        {
            var menu = new Menu();
            menu.AddOption(new MenuOption { Id = 1, Description = "First Option", Type = OptionType.Printer_Model_2000 });
            menu.AddOption(new MenuOption { Id = 2, Description = "Second Option", Type = OptionType.Printer_Model_2004 });
            menu.AddOption(new MenuOption { Id = 3, Description = "Third Option", Type = OptionType.Printer_Model_2006 });
            menu.Display();
        }
    }
}
