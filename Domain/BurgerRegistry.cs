
using System;

namespace Domain
{
    interface IBurgerRegistry
    {
        double CalculatePrice(int numberOfBurgers, int burgerPrize);
    }

    public class BurgerRegistry : IBurgerRegistry
    {
        public virtual double CalculatePrice(int numberOfBurgers, int burgerPrize)
        {
            return numberOfBurgers * burgerPrize;
        }
    }

    public class QuarterReductionBurgerRegistry : BurgerRegistry
    {
        public override double CalculatePrice(int numberOfBurgers, int burgerPrize)
        {
            int numberOfFreeBurgers = (int)Math.Floor(Decimal.Divide(numberOfBurgers, 4));
            return (numberOfBurgers - numberOfFreeBurgers) * burgerPrize;
        }
    }

    public class FiftyPercentReductionBurgerRegistry : BurgerRegistry
    {
        public override double CalculatePrice(int numberOfBurgers, int burgerPrize)
        {
            return (numberOfBurgers* burgerPrize) * 0.5;
        }
    }
}
