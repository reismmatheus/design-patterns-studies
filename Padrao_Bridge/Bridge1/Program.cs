using Bridge1.ConcreteImplementor;
using Bridge1.Domain;
using Bridge1.RefinedAbstration;
using System;

namespace Bridge1
{
    class Program
    {
        static void Main(string[] args)
        {
            // RedefinedAbstraction recebe via construtor em tempo de execução 
            // o tipo especifico de formato para gerar o arquivo
            // e usa a classe base AbstractionGeraArquivo para obter uma instância
            // de IGeraArquivo (Bridge)
            CalculaSalario calculaSalario = new CalculaSalario(new GeraXML());

            //define os dados do funcionário
            Funcionario funcionario = new Funcionario
            { 
                  Id = 101, Nome = "Macoratti", SalarioBase = 3000,
                  Incentivo = 2000 
            };

            //processa o salario
            calculaSalario.ProcessaSalarioFuncionario(funcionario);

            //altera o valor do incentivo em tempo de execução
            funcionario.Incentivo= 2500;

            //altera o formato para gerar o arquivo em tempo de execução
            calculaSalario = new CalculaSalario(new GeraJson());
            
            calculaSalario.ProcessaSalarioFuncionario(funcionario);
            
            Console.ReadKey();
        }
    }
}
