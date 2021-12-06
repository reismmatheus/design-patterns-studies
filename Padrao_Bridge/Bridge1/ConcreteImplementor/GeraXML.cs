using Bridge1.Domain;
using Bridge1.Implementor;
using System;
using System.IO;
using System.Xml.Serialization;

namespace Bridge1.ConcreteImplementor
{
    public class GeraXML : IGeraArquivo
    {
        private string nomeArquivo = "SalarioFuncionario.xml";
        private XmlSerializer xmlSerializer = new XmlSerializer(typeof(Funcionario));
        private FileStream fileStream;

        public void GravaArquivo(Funcionario funcionario)
        {
            fileStream = new FileStream(nomeArquivo, FileMode.OpenOrCreate);

            xmlSerializer.Serialize(fileStream, funcionario);

            Console.WriteLine($"Salário para o Funcionário : {funcionario.Nome} " +
                $"gerado com sucesso em : {nomeArquivo} \n");
        }
    }
}
