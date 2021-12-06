using Adapter2.Domain;
using System;
using System.Collections.Generic;

namespace Adapter2.Adaptee
{
    public class SistemaMensalidades
    {
        public void CalculaMensalidade(List<Aluno> listaAlunos)
        {
            foreach (Aluno aluno in listaAlunos)
            {
                //Usa uma lógica para calcular a mensalidade
                Console.WriteLine($"Aluno {aluno.Nome} " +
                    $"- Valor da mensalidade R$ {aluno.Mensalidade}");
            }
        }
    }
}
