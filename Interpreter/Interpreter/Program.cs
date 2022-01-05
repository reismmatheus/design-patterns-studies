using System;
using System.Collections.Generic;

namespace Interpreter1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IAbstractExpression> expressoes = new List<IAbstractExpression>();

            Context context = new Context(DateTime.Now);
            Console.WriteLine($"Data atual : {context.Data}\n");

            Console.WriteLine("Selecione a expressão a usar : MM-DD-YYYY  ou  YYYY-MM-DD  " +
                "ou  DD-MM-YYYY ");

            context.Expressao = Console.ReadLine().ToUpper();

            string[] formato = context.Expressao.Split('-');

            foreach (var item in formato)
            {
                if (item == "DD")
                {
                    expressoes.Add(new ExpressaoDia());
                }
                else if (item == "MM")
                {
                    expressoes.Add(new ExpressaoMes());
                }
                else if (item == "YYYY")
                {
                    expressoes.Add(new ExpressaoAno());
                }
            }

            expressoes.Add(new Separador());
            
            foreach (var obj in expressoes)
            {
                obj.Avaliar(context);
            }

            Console.WriteLine($"\nData na expressão escolhida : {context.Expressao}");
            
            Console.Read();
        }
    }
}
