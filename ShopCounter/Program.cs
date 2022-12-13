using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ShopCounter
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введіть кількість прилавків:");
            int shopsQuantity = int.Parse(Console.ReadLine());

            int[] shopsMoneyToEnergyUsageArray = new int[shopsQuantity];

            Console.WriteLine("Введіть суму витрачену прилавками:");
            float moneyWasted = int.Parse(Console.ReadLine());


            for (int i = 0; i < shopsQuantity; i++)
            {
                Console.WriteLine($"Введіть кількість грошей, витрачену прилавком #{i + 1}");
                shopsMoneyToEnergyUsageArray[i] = int.Parse(Console.ReadLine());
            }

            float[] percentageOfEveryShopArray = new float[shopsQuantity];
            for (int i = 0; i < shopsMoneyToEnergyUsageArray.Length; i++)
            {
                Thread.Sleep(200);
                percentageOfEveryShopArray[i] = (shopsMoneyToEnergyUsageArray[i] * 100) / moneyWasted;
                Console.WriteLine($"Прилавок #{i + 1} використав {percentageOfEveryShopArray[i]}% від загальної суми");
            }

            Console.WriteLine($" Кількість відсотків загалом (щоб розуміти точність результатів) {percentageOfEveryShopArray.Sum()}");

            Console.WriteLine("Введіть кількість грошей, яку потрібно розподілити між прилавками");
            int moneyToPay = int.Parse(Console.ReadLine());
            float[] moneyToPayArray = new float[shopsQuantity];
            for (int i = 0; i < moneyToPayArray.Length; i++)
            {
                Thread.Sleep(200);
                moneyToPayArray[i] = (moneyToPay * percentageOfEveryShopArray[i]) / 100;
                Console.WriteLine($"Прилавок #{i + 1} має сплатити {moneyToPayArray[i]} грн");
            }
        }
    }
}