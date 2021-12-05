using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    public class OperationCoffee
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Coffee Coffee { get; set; }
    }
}
