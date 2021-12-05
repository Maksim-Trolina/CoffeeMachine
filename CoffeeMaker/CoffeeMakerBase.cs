namespace CoffeeMaker
{
    public abstract class CoffeeMakerBase
    {
        protected CoffeeMachine CoffeeMachine { get; set; }
        public string CoffeeNameMake { get; set; }
        public CoffeeMakerBase(CoffeeMachine coffeeMachine, string coffeeNameMake)
        {
            CoffeeMachine = coffeeMachine;
            CoffeeNameMake = coffeeNameMake;
        }

        public abstract Coffee MakeCoffee(StrengthCoffee strengthCoffee, MugVolume mugVolume);

        protected void CheckPossibillityMakeCoffee(double needWaterVolume, double needGrainsGram)
        {
            if (needWaterVolume > CoffeeMachine.WaterVolume)
                throw new Exception("Not enough water");
            if (needGrainsGram > CoffeeMachine.GrainsGram)
                throw new Exception("Not enough grains");
        }

        protected void UseResoureces(double needWaterVolume, double needGrainsGram)
        {
            CoffeeMachine.WaterVolume -= needWaterVolume;
            CoffeeMachine.GrainsGram -= needGrainsGram;
            CoffeeMachine.PollutionLevel++;
        }
    }
}
