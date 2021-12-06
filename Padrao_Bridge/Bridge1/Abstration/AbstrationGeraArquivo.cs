using Bridge1.Domain;
using Bridge1.Implementor;

namespace Bridge1.Abstration
{
    public abstract class AbstrationGeraArquivo
    {
        protected IGeraArquivo geraArquivo;

        protected AbstrationGeraArquivo(IGeraArquivo geraArquivo)
        {
            this.geraArquivo = geraArquivo;
        }

        public virtual void GravaArquivo(Funcionario funcionario)
        {
            geraArquivo.GravaArquivo(funcionario);
        }
    }
}
