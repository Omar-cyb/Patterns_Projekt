namespace Factory_Method
{
    public abstract class PizzaFactory
    {
        public abstract Pizza CreatePizza(string type);
    }
}