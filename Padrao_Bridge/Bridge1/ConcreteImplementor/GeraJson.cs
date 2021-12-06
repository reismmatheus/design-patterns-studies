using Bridge1.Domain;
using Bridge1.Implementor;
using System;
using System.IO;
using System.Text.Json;

namespace Bridge1.ConcreteImplementor
{
    public class GeraJson : IGeraArquivo
    {
        private string nomeArquivo = "SalarioFuncionario.json";

        public void GravaArquivo(Funcionario funcionario)
        {
            var funcionarioSerializado = JsonSerializer.Serialize(funcionario);

            File.WriteAllText(nomeArquivo, funcionarioSerializado);

            Console.WriteLine($"Salário para o Funcionário : {funcionario.Nome} " +
                $"gerado com sucesso em : {nomeArquivo} \n");
        }
    }
}
