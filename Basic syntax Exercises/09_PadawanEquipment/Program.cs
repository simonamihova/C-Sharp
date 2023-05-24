using System.Drawing;
using System.Reflection.Emit;

namespace _09_PadawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            float johnMoney = float.Parse(Console.ReadLine());  
            int studentCount = int.Parse(Console.ReadLine());
            float lightSaberPrice = float.Parse(Console.ReadLine());
            float robePrice = float.Parse(Console.ReadLine());
            float beltPrice = float.Parse(Console.ReadLine());


            int lightSaberCount = 0;
            int beltCount = studentCount;
            float totalSum = 0;
            float change = 0;


            lightSaberCount = (int)Math.Ceiling(studentCount + (studentCount * 0.1));
           
            if (studentCount >= 6) 
            {
                beltCount  = studentCount - (studentCount/6);
            }

            totalSum = (lightSaberCount * lightSaberPrice) + (beltCount * beltPrice) + studentCount * robePrice;

            if (totalSum > johnMoney)
            {
                change =  totalSum - johnMoney;
                Console.WriteLine($"John will need {change:F2}lv more.");
            }
            else
            {
                Console.WriteLine($"The money is enough - it would cost {totalSum:F2}lv.");
            }

          

        }
    }
}