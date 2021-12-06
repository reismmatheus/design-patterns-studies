using Adapter1.Adapter;
using Adapter1.Domain;
using System;

namespace Adapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            int baseTriangulo = 0; 
            int alturaTriangulo = 0;

            Console.WriteLine("***Padrão Adapter Demo***\n");
            CalculadoraAdapter cal = new CalculadoraAdapter();
          
            Console.WriteLine("Informe a base do triângulo : ");
            baseTriangulo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a altura do triângulo : ");
            alturaTriangulo = Convert.ToInt32(Console.ReadLine());
            
            Triangulo t = new Triangulo(baseTriangulo, alturaTriangulo);

            Console.WriteLine("Area do Triangulo é " + cal.GetArea(t) 
                + " metros quadrados");
            
            Console.ReadKey();
        }
    }
}
