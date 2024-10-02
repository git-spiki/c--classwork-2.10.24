using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService OR = new OrderService();
            Product cola = new Product("cola", 10, 25);
            Product chip = new Product("chip", 1000, 5);

            Customer jeff = new Customer("Jeff", "go@go.go", "гоголя 44", "седанка", "666");
            Customer bob = new Customer("Bob", "gmail", "какой-то 42", "архангельск", "394856");

            Order zakaz1 = new Order(cola, jeff);
            Order zakaz2 = new Order(chip, bob);

            OR.AddOrder(zakaz1);
            OR.AddOrder(zakaz2);

            List<Order> ListOrders = OR.GetOrders();

            for (int i = 0; i < ListOrders.Count; i++)
            {
                Order shortcut = ListOrders[i];
                Customer vCust = shortcut.customer;
                Product vProd = shortcut.product;
                double TotalPrice = shortcut.CalculateTotalPrice();
                string address = vCust.address.ToString();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Заказ #{i+1}");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"#Покупатель:\nИмя: {vCust.Name}\nEmail: {vCust.Email}\nАдрес: {address}\n");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"#Товар:\nНазвание: {vProd.Name}\nЦена за штуку: {vProd.Price}\nКоличество: {vProd.Quanity}\nОбщая стоимость: {TotalPrice}\n");
            }
            Console.ReadLine();
        }
    }
}
