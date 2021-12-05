using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    public class LatteMaker : CoffeeMakerBase
    {   
        public LatteMaker(CoffeeMachine coffeeMachine, string coffeeNameMake) : base(coffeeMachine, coffeeNameMake) { }

        public override Coffee MakeCoffee(StrengthCoffee strengthCoffee, MugVolume mugVolume)
        {
            double needGrainsGram = 11.1 * (int)strengthCoffee;

            int mugVolumeValue = (int)mugVolume;

            double needWaterVolume = mugVolumeValue - 3.3 * needGrainsGram;

            CheckPossibillityMakeCoffee(needWaterVolume, needGrainsGram);

            UseResoureces(needWaterVolume, needGrainsGram);

            return new Coffee(CoffeeNameMake, needGrainsGram, mugVolume);
        }
    }
}
