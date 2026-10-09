using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    public abstract class Drink
    {
        public abstract string Name { get; }
        public abstract decimal Price { get; }
        public abstract void Prepare();

        public void Serve()
        {
            Console.WriteLine($"Напиток {Name} подан");
        }
    }
}