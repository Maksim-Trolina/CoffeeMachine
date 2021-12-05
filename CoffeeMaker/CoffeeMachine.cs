using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CoffeeMaker
{
    public class CoffeeMachine : INotifyPropertyChanged
    {
        const double MaxWaterVolume = 3000;
        const double MaxGrainsGram = 300;
        const double MaxPollutionLevel = 100;

        double pollutionLevel;
        double waterVolume;
        double grainsGram;
        public double WaterVolume
        {
            get => waterVolume;
            set
            {
                waterVolume = Math.Min(value, MaxWaterVolume);
                InvokePropertyChanged(new PropertyChangedEventArgs("WaterVolume"));
            }
        }
        public double GrainsGram
        {
            get => grainsGram;
            set
            {
                grainsGram = Math.Min(value, MaxGrainsGram);
                InvokePropertyChanged(new PropertyChangedEventArgs("GrainsGram"));
            }
        }

        public double PollutionLevel
        {
            get => pollutionLevel;
            set
            {
                pollutionLevel = Math.Min(value, MaxPollutionLevel);
                InvokePropertyChanged(new PropertyChangedEventArgs("PollutionLevel"));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void InvokePropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, e);
        }

        public Coffee MakeCoffee(StrengthCoffee strengthCoffee, MugVolume mugVolume, CoffeeMakerBase coffeeMaker) => coffeeMaker.MakeCoffee(strengthCoffee, mugVolume);

        public void Clean() => PollutionLevel = 0;
    }
}
