
namespace Domain
{
    public class Registry
    {
        private const int BURGER_PRIZE = 3;

        public double GetOrderPrice(int numberOfBurgers)
        {
            IBurgerRegistry burgerRegistry = numberOfBurgers switch
            {
                < 3 => new BurgerRegistry(),
                <= 10 => new QuarterReductionBurgerRegistry(),
                > 11 => new FiftyPercentReductionBurgerRegistry(),
                _ => new BurgerRegistry()
            };

            return burgerRegistry.CalculatePrice(numberOfBurgers, BURGER_PRIZE);
        }
    }
}
