using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CoffeeMaker
{
    public enum StrengthCoffee
    {
        Mild = 2,
        Strong = 4
    }

    public enum MugVolume
    {
        Half = 200,
        Full = 400
    }
   
    public class Coffee
    {
        public int Id { get; set; }
        public double CaffeineGram { get; set; }
        public string? Name { get; set; }
        public MugVolume MugVolume { get; set; }

        public Coffee(string name, double caffeineGram, MugVolume mugVolume)
        {
            Name = name;
            CaffeineGram = caffeineGram;
            MugVolume = mugVolume;
        }

        public override string ToString()
        {
            return $"Coffee: {Name}\nCaffeine gram: {CaffeineGram}g\nMug volune: {(int)MugVolume}ML";
        }
    }
}
