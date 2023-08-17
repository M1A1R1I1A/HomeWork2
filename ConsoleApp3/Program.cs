using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Vvedite nomer: ");
            //int dayIndex = int.Parse(Console.ReadLine());


            /// if (dayIndex == 1) Console.WriteLine("PONEDELNIK");
            // else if (dayIndex == 2) Console.WriteLine("VTORNIK");
            // else if (dayIndex == 3) Console.WriteLine("SREDA");
            // else Console.WriteLine("Ape tenc or chunenq");


            Random rand = new Random();

              int firstNumber = rand.Next(-20, 50);
              int secondNumber = rand.Next(-20, 50);
              int thirdNumber = rand.Next(-20, 50);

             int maxValue;

            if ((firstNumber < secondNumber) && (firstNumber < thirdNumber))
            {
                maxValue = firstNumber;
            }
             else
             {
              if ((secondNumber < thirdNumber))
              {
                 maxValue = secondNumber;
               }
            else
            {
                 maxValue = thirdNumber;
               }
             }

            Console.WriteLine($"Maksimalnoe znachenie = {maxValue}  ");




            //Console.WriteLine("Vvedite start");
           // int start = Convert.ToInt32(Console.ReadLine());

            //for (int i = start; i <= start + 10; i++) 
           // {
             //Console.WriteLine($"{i,4}^2 = {i * i}");
               // }


                Console.ReadKey();






            }





    }
}
