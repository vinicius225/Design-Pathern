
namespace SimpleFactory.Pizza
{
    public class PizzaSimpleFactory
    {
        public static Object CiarPizza (string pizza)
        {
             Pizza pizzaNome;
            switch (pizza) 
            {
                case "c":
                pizzaNome = new PizzaCalabreza();
                break;
                case "m":
                pizzaNome = new PizzaMussarela();
                break;
                default:
                throw new ApplicationException($"A pizza {pizza} não foi cadastrada no sistema.");
            }
            return pizzaNome;
        }
    }
}