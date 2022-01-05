namespace Interpreter1
{
        public class Separador : IAbstractExpression
        {
            public void Avaliar(Context context)
            {
                string espressao = context.Expressao;
                context.Expressao = espressao.Replace(" ", "-");
            }
        }
}
