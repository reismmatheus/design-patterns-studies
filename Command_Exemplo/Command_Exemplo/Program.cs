using System;

namespace Command_Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("## Command ##\n");
            //Receiver
            var chef = new Chef();

            var order = new Order(chef, "Food");
            var waiter = new Waiter(order);
            waiter.Executar();

            //sobremesa
            order = new Order(chef, "Dessert");
            waiter = new Waiter(order);
            waiter.Executar();

            Console.ReadKey();
        }
    }
}
