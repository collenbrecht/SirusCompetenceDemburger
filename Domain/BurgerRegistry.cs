
using System;

namespace Domain
{
    interface IBurgerRegistry
    {
        public double CalculatePrice(int numberOfBurgers, int burgerPrize)
        {
            return numberOfBurgers * burgerPrize;            
        }
    }

    public class BurgerRegistry : IBurgerRegistry
    {
    }

    public class QuarterReductionBurgerRegistry : IBurgerRegistry
    {
        public double CalculatePrice(int numberOfBurgers, int burgerPrize)
        {
            int numberOfFreeBurgers = (int)Math.Floor(Decimal.Divide(numberOfBurgers, 4));
            return (numberOfBurgers - numberOfFreeBurgers) * burgerPrize;
        }
    }

    public class FiftyPercentReductionBurgerRegistry : IBurgerRegistry
    {
        public double CalculatePrice(int numberOfBurgers, int burgerPrize)
        {
            return (numberOfBurgers* burgerPrize) * 0.5;
        }
    }
}
