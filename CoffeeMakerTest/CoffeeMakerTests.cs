using NUnit.Framework;
using CoffeeMaker;

namespace CoffeeMakerTest
{
    public class CoffeeMakerTests
    {

        [Test]
        public void MakeCoffeeTest()
        {
            CoffeeMachine coffeeMachine = new CoffeeMachine { GrainsGram = 300, PollutionLevel = 2, WaterVolume = 3000 };
            object[] testCases =
            {
                new object[] { new AmericanoMaker(coffeeMachine, "Americano"), StrengthCoffee.Strong, MugVolume.Half, new Coffee("Americano", 80, MugVolume.Half) },
                new object[] { new CappuccinoMaker(coffeeMachine, "Cappuccino"), StrengthCoffee.Strong, MugVolume.Half, new Coffee("Cappuccino", 58, MugVolume.Half) },
                new object[] { new LatteMaker(coffeeMachine, "Latte"), StrengthCoffee.Strong, MugVolume.Half, new Coffee("Latte", 44.4, MugVolume.Half) },
            };

            foreach(var testCase in testCases)
            {
                var args = (object[])testCase;
                var coffeeMaker = (CoffeeMakerBase)args[0];
                var strengthCoffee = (StrengthCoffee)args[1];
                var mugVolume = (MugVolume)args[2];
                var expectedCoffee = (Coffee)args[3];

                Coffee actualCoffee = coffeeMaker.MakeCoffee(strengthCoffee, mugVolume);

                Assert.True(AreEqual(actualCoffee, expectedCoffee));
            }
        }

        bool AreEqual(Coffee coffee1, Coffee coffee2)
        {
            return coffee1.MugVolume == coffee2.MugVolume
                && coffee1.CaffeineGram == coffee2.CaffeineGram
                && coffee1.Name == coffee2.Name;
        }
    }
}