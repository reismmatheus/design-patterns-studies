using Decorator1.Component;
using Decorator1.ConcreteComponent;
using Decorator1.ConcreteDecorator;
using System;

namespace Decorator1
{
    class Program
    {
        static void Main(string[] args)
        {
            IPizza pizza = new Pizza();

            Console.WriteLine(pizza.Opcionais());
            Console.WriteLine($"Preco R$ {pizza.Preco()}\n");
            Console.WriteLine("Tecle algo para aplicar o padrão Decorator");
            Console.ReadKey();
            
            Console.WriteLine("------ Aplicando o Decorator ------------------");

            IPizza pizza2 = new Pizza();
            IPizza massaEspecial = new MassaEspecialDecorator(pizza2);
            IPizza baconDecorator = new BaconDecorator(massaEspecial);
            IPizza bordaDecorator = new BordaRecheadaDecorator(baconDecorator);

            //Exibe Tipo e Preco
            Console.WriteLine(bordaDecorator.Opcionais());
            Console.WriteLine($"Preco Total R$ : {bordaDecorator.Preco()}\n");
            Console.ReadKey();
        }
    }
}
