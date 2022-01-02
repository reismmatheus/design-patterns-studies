namespace Command_Exemplo
{
    //Invoker
    public class Waiter
    {
        private Order _order;
        public Waiter(Order order)
        {
            _order = order;
        }
        public void Executar()
        {
            _order.Execute();
        }
    }
}
