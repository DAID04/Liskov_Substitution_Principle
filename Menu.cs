using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle
{
    public enum OptionType
    {
        Printer_Model_2000,
        Printer_Model_2004,
        Printer_Model_2006
    }

    public struct MenuOption
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public OptionType Type { get; set; }
    }

    public class Menu
    {
        private List<MenuOption> _options;

        public Menu()
        {
            _options = new List<MenuOption>();
        }

        public void AddOption(MenuOption option)
        {
            _options.Add(option);
        }

        public void Display()
        {
            Console.WriteLine("Bienvenido, digite su opcion:");
            foreach (var option in _options)
            {
                Console.WriteLine($"{option.Id}. {option.Description}");
            }
        }
    }
}
