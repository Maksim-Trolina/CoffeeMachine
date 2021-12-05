namespace CoffeeMaker
{
    public partial class Form1 : Form
    {
        CoffeeMachine coffeeMachine;
        public Form1()
        {
            InitializeComponent();

            coffeeMachine = new CoffeeMachine();

            listCoffeeMakers.DataSource = new CoffeeMakerBase[]
            {
                new AmericanoMaker(coffeeMachine, "Americano"),
                new CappuccinoMaker(coffeeMachine, "Cappuccino"),
                new LatteMaker(coffeeMachine, "Latte")
            };

            listCoffeeMakers.DisplayMember = "CoffeeNameMake";

            mugVolumeList.DataSource = new MugVolume[]
            {
                MugVolume.Half,
                MugVolume.Full
            };

            strengthCoffeeList.DataSource = new StrengthCoffee[]
            {
                StrengthCoffee.Mild,
                StrengthCoffee.Strong
            };

            pollutionLevel.DataBindings.Add("Text", coffeeMachine, "PollutionLevel");
            waterVolume.DataBindings.Add("Text", coffeeMachine, "WaterVolume");
            grainsGram.DataBindings.Add("Text", coffeeMachine, "GrainsGram");
          
        }

        void CleanBtnClick(object sender, EventArgs e) => coffeeMachine.Clean();

        void MakeCoffeeBtnClick(object sender, EventArgs e)
        {
            var strengthCoffee = (StrengthCoffee)strengthCoffeeList.SelectedItem;
            var mugVolume = (MugVolume)mugVolumeList.SelectedItem;
            var coffeeMaker = (CoffeeMakerBase)listCoffeeMakers.SelectedItem;

            try
            {
                Coffee coffee = coffeeMachine.MakeCoffee(strengthCoffee, mugVolume, coffeeMaker);
                MessageBox.Show(coffee.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void AddWaterBtnClick(object sender, EventArgs e) => coffeeMachine.WaterVolume += (double) waterVolumeNumeric.Value;


        void AddGrainsBtnClick(object sender, EventArgs e) => coffeeMachine.GrainsGram += (double)grainsGramNumeric.Value;

    }
}