namespace Command_Exemplo
{
    //ConcreteCommand
    public class Order : Command
    {
        private Chef _chef { get; set; }
        private string _action { get; set; }
        public Order(Chef chef, string action)
        {
            _chef = chef;
            _action = action;
        }
        public override void Execute()
        {
            if (_action.Equals("Food"))
            {
                _chef.MakeFood();
            }
            else
            {
                _chef.MakeDessert();
            }
        }
    }
}
