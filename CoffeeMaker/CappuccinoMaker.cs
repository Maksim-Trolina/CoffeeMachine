using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace CoffeeMaker
{
    public class CappuccinoMaker : CoffeeMakerBase
    {
        public CappuccinoMaker(CoffeeMachine coffeeMachine, string coffeeNameMake) : base(coffeeMachine, coffeeNameMake) { }

        public override Coffee MakeCoffee(StrengthCoffee strengthCoffee, MugVolume mugVolume)
        {
            double needGrainsGram = 14.5 * (int)strengthCoffee;

            int mugVolumeValue = (int)mugVolume;

            double needWaterVolume = mugVolumeValue - 2.2 * needGrainsGram;

            CheckPossibillityMakeCoffee(needWaterVolume, needGrainsGram);

            UseResoureces(needWaterVolume, needGrainsGram);

            return new Coffee(CoffeeNameMake, needGrainsGram, mugVolume);
        }
    }
}
