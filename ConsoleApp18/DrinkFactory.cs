using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    public static class DrinkFactory
    {
        public static Drink CreateDrink(string type)
        {
            string lower = type.ToLower();
            switch (lower)
            {
                case "кофе":
                    return new Coffee();
                case "чай":
                    return new Tea();
                case "смузи":
                    return new Smoothie();
                default:
                    return null;
            }
        }
    }


}