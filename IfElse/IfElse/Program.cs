using System;

namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            bool hasMoney = false;
            if (hasMoney)
            {
                Console.WriteLine("Yey, You have money");
            }
            else
            {
                Console.WriteLine("Ou, You dont have money");
            }

            int age = 15;

            if (age < 18)
            {
                Console.WriteLine("Sveiks jaunieti");
            }
            else if (age >= 70)
            {
                Console.WriteLine("Sveiks senjor!");
            }
            else
            {
                Console.WriteLine("Sveiks peaigušais");
            }

            if (age >= 18 && age < 70)
            {
                Console.WriteLine("Sveiks peaigušais");
            }






            int sequenceNumber = 2;

            switch (sequenceNumber)
            {
                case 1:
                    Console.WriteLine("This is case 1");
                    break;
                case 2:
                    Console.WriteLine("This is case 2");
                    break;
                case 3:
                    Console.WriteLine("This is case 3");
                    break;
                default:
                    Console.WriteLine("No case was valid");
                    break;
            }

            string name2 = "Artis";

            switch (name2)
            {
                case "Artis":
                    Console.WriteLine("This is case 1");
                    break;
                case "B":
                    Console.WriteLine("This is case 2");
                    break;
                case "A":
                    Console.WriteLine("This is case 3");
                    break;
                default:
                    Console.WriteLine("No case was valid");
                    break;
            }


        }
    }
}
