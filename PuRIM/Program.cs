using System;
using System.IO;

namespace PuRIM
{
    class Program
    {
        static void Main(string[] args) => new Program().Start();

        private dynamic _im;
        public void Start()
        {
            _im = new InventoryManager();
            if (File.Exists("products.json"))
            {
                _im.Load();
            }
         
            Console.Title = "PuRIM";
            Console.WriteLine("How many products do you wanna add?");
            var o = int.Parse(Console.ReadLine());
            for (int i = 0; i <= o; i++)
            {
                Console.WriteLine("Add a new product name");
                var name = Console.ReadLine();
                Console.WriteLine("Add a new product price");
                var price = double.Parse(Console.ReadLine());
                Console.WriteLine("Add a ammount of product stocked");
                var ammount = int.Parse(Console.ReadLine());
                Console.WriteLine("Add a type of product ");
                var type = Console.ReadLine();
                _im.AddProduct(type, name, price, ammount);
               
            }
            _im.Save();
            foreach (Product p in _im.ListAllProducts())
            {
                Console.WriteLine($"{p.Name} {p.Value}");
            }
            Console.ReadLine();
        }
    }
}