using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    public class Coffee : Drink
    {
        public override string Name
        {
            get { return "Кофе"; }
        }

        public override decimal Price
        {
            get { return 250; }
        }

        public override void Prepare()
        {
            Console.WriteLine("Готовим кофе");
        }
    }
}