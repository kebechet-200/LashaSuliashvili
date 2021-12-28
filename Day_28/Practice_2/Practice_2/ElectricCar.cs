using System.Threading.Tasks;

namespace Practice_2
{
    public class ElectricCar
    {
        public int BatteryLevel { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public void Charge()
        {
            while (BatteryLevel < 100)
            {
                Task.Delay(10000);
                BatteryLevel += 5;
            }
        }
    }
}