using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    public class Smoothie : Drink
    {
        public override string Name
        {
            get { return "Смузи"; }
        }

        public override decimal Price
        {
            get { return 350; }
        }

        public override void Prepare()
        {
            Console.WriteLine("Готовим смузи");
        }
    }
}