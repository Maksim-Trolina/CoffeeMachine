using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    public class AmericanoMaker : CoffeeMakerBase
    {
        public AmericanoMaker(CoffeeMachine coffeeMachine, string coffeeNameMake) : base(coffeeMachine, coffeeNameMake) { }

        public override Coffee MakeCoffee(StrengthCoffee strengthCoffee, MugVolume mugVolume)
        {
            double needGrainsGram = 20 * (int)strengthCoffee;

            int mugVolumeValue = (int)mugVolume;

            double needWaterVolume = mugVolumeValue - needGrainsGram;

            CheckPossibillityMakeCoffee(needWaterVolume, needGrainsGram);

            UseResoureces(needWaterVolume, needGrainsGram);

            return new Coffee(CoffeeNameMake, needGrainsGram, mugVolume);
        }
    }
}
