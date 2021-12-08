using Composite1.Composite;
using Composite1.Leaf;
using System;

namespace Composite1
{
    //Client
    class Program
    {
        static void Main(string[] args)
        {
            Organizacao organizacao = new Organizacao { Nome = "JcmSoft Inc." };
            //
            Organizacao departamentoTI = new Organizacao { Nome = " TI " };
            departamentoTI.Add(new Funcionario { Id = 1001, Nome = "Maria", Horas = 8 });
            departamentoTI.Add(new Funcionario { Id = 1002, Nome = "Miguel", Horas = 6 });
            departamentoTI.Add(new Funcionario { Id = 1005, Nome = "Samuel", Horas = 8 });
            //
            Organizacao departamentoContabilidade = new Organizacao { Nome = " Contabilidade " };
            departamentoContabilidade.Add(new Funcionario { Id = 1003, Nome = "Beatriz", Horas = 7 });
            departamentoContabilidade.Add(new Funcionario { Id = 1004, Nome = "Paulo", Horas = 5 });
            //
            organizacao.Add(departamentoTI);
            organizacao.Add(departamentoContabilidade);
            organizacao.GetHoraTrabalhada();
            //
            Console.ReadKey();
        }
    }
}
