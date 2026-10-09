using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    public class Tea : Drink
    {
        public override string Name
        {
            get { return "Чай"; }
        }

        public override decimal Price
        {
            get { return 150; }
        }

        public override void Prepare()
        {
            Console.WriteLine("Готовим чай");
        }
    }
}