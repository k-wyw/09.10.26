using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n Главное меню ");
                Console.WriteLine("1. Добавить заказ в OrderManager");
                Console.WriteLine("2. Показать отчёт OrderManager");
                Console.WriteLine("3. Заказать напиток");
                Console.WriteLine("0. Выход");
                Console.Write("Выберите пункт: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": AddOrder(); break;
                    case "2": OrderManager.Instance.PrintReport(); break;
                    case "3": OrderDrink(); break;
                    case "0": running = false; Console.WriteLine("Выход"); break;
                    default: Console.WriteLine("Неверный пункт."); break;
                }
            }
        }

        static void AddOrder()
        {
            Console.WriteLine("\n Добавление заказа ");

            decimal amount = 0;
            while (amount <= 0)
            {
                Console.Write("Сумма заказа: ");
                if (decimal.TryParse(Console.ReadLine(), out amount) == false)
                {
                    Console.WriteLine("Введите число.");
                    amount = 0;
                }
                else if (amount <= 0)
                {
                    Console.WriteLine("Сумма должна быть больше нуля.");
                }
            }

            OrderManager.Instance.AddOrder(amount);
        }

        static void OrderDrink()
        {
            Console.WriteLine("\n Заказ напитка ");
            Console.WriteLine("Доступные напитки: Кофе, Чай, Смузи");
            Console.Write("Что будете заказывать? ");
            string type = Console.ReadLine();

            Drink drink = DrinkFactory.CreateDrink(type);

            if (drink == null)
            {
                Console.WriteLine("Такого напитка нет.");
                return;
            }

            drink.Prepare();
            drink.Serve();

            OrderManager.Instance.AddOrder(drink.Price);
        }
    }
}