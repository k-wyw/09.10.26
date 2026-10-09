using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    public class OrderManager
    {
        private static readonly OrderManager _instance = new OrderManager();

        private OrderManager() { }

        public static OrderManager Instance
        {
            get { return _instance; }
        }

        public decimal TotalSum { get; private set; }
        public int ClientsCount { get; private set; }

        public void AddOrder(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Сумма заказа должна быть больше нуля.");
                return;
            }

            TotalSum = TotalSum + amount;
            ClientsCount = ClientsCount + 1;
            Console.WriteLine($"Заказ на сумму {amount} добавлен.");
        }

        public void PrintReport()
        {
            Console.WriteLine($"Общая выручка: {TotalSum} руб.");
            Console.WriteLine($"Обслужено клиентов: {ClientsCount}");
        }
    }
}