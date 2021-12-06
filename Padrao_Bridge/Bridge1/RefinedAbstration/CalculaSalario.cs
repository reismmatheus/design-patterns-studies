using Bridge1.Abstration;
using Bridge1.Domain;
using Bridge1.Implementor;
using System;

namespace Bridge1.RefinedAbstration
{
    public class CalculaSalario : AbstrationGeraArquivo
    {
        public CalculaSalario(IGeraArquivo geraArquivo) : base(geraArquivo)
        { }

        public void ProcessaSalarioFuncionario(Funcionario funcionario)
        {

            funcionario.SalarioTotal = funcionario.SalarioBase + funcionario.Incentivo;

            Console.WriteLine($"Valor do Salário Total para o funcionario {funcionario.Id} \n" +
                $": R$ {funcionario.SalarioTotal}");

            geraArquivo.GravaArquivo(funcionario);
        }
    }
}
