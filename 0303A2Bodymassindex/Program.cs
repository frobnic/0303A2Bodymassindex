using System;

namespace _0303A2Bodymassindex
{
    class Program
    {
        static void Main(string[] args)
        {
            float g; // gewicht in kg
            float h; // hoehe in metern
            int j; // alter in jahren
            bool flag; // flag fuer BMI nicht ok
            int bmi;

            Console.Write("Gewicht in kg   : ");
            g = float.Parse(Console.ReadLine());

            Console.Write("Grösse in m     : ");
            h = float.Parse(Console.ReadLine());

            Console.Write("Alter in Jahren : ");
            j = int.Parse(Console.ReadLine());


            bmi = (int)Math.Round(g / (h * h));

            Console.WriteLine("Sie haben einen BMI von {0}", bmi);

            flag = false;

            if (j > 64)
                flag = (bmi < 24 || bmi > 29);
            else if (j > 54)
                flag = (bmi < 23 || bmi > 28);
            else if (j > 44)
                flag = (bmi < 22 || bmi > 27);
            else if (j > 34)
                flag = (bmi < 21 || bmi > 26);
            else if (j > 24)
                flag = (bmi < 20 || bmi > 25);
            else if (j > 18)
                flag = (bmi < 19 || bmi > 24);
            else
                Console.WriteLine("BMI-Angaben sind für Kinder und Jugendliche nicht Sinnvoll.");

            if (!flag)
                Console.WriteLine("netter Hinweis");
            else
                Console.WriteLine("vorsichtige Warnung");
        }
    }
}
