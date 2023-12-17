using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Runtime;

namespace ab319_4_1_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // DrawSquare(7);

            // Aufgabe 4.2
            // Introduction();

            // Aufgabe 4.3
            // MonthSeconds();

            // Aufgabe 4.4
            // Show_Manual();

            // Aufgabe 4.7
            // biggest_number();

            // Aufgabe 4.8
            // random_comma_numbers();
            
            // Aufgabe 5.5
            GCD(2,4);

        }

        // FUNKTIONEN / METHODEN
        static void DrawSquare(int count)
        {
            for (int j = 0; j < count; j++)
            {
                for (int i = 0; i < count; i++)
                {
                    Console.Write("\u2663  ");
                }

                Console.WriteLine();
            }
        }

        // Aufgabe 4.2 - Introduction
        static void Introduction()
        {
            Console.Write("Bitte geben Sie Ihren Nachnamen ein: ");
            string last_name = Console.ReadLine();
            Console.Write("Bitte geben Sie Ihren Vornamen ein: ");
            string first_name = Console.ReadLine();
            Console.WriteLine("Ihr Name lautet: " + first_name + " " + last_name);
            Console.Write("Bitte geben Sie eine Kommazahl ein: ");
            float decimal_num = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Das tausendfache Ihrer Kommazahl lautet: " + decimal_num * 1000);
            Console.Write("Bitte geben Sie eine ganze Zahl ein: ");
            int normal_number = Convert.ToInt32(Console.ReadLine());
            if (normal_number % 2 == 0)
            {
                Console.WriteLine("Sie haben eine gerade Zahl eingegeben.");
            }
            else
            {
                Console.WriteLine("Sie haben eine ungerade Zahl eingegeben.");
            }

            Console.Write("Das Quadrat Ihrer Zahl lautet: " + normal_number * normal_number);
        }

        // Aufgabe 4.3 - MonthSeconds
        static void MonthSeconds()
        {
            Console.WriteLine("Wie viele Tage hat den Monat, für den Sie die Sekudnen berechnen wollen?");
            int month_days = Convert.ToInt32(Console.ReadLine());
            double total_seconds = month_days * 86400;
            Console.Write("Ein Monat mit " + month_days + " Tagen hat " + total_seconds + " Sekunden");
        }

        // Aufgabe 4.4 - Memory
        static void Show_Manual()
        {
            Console.WriteLine("Herzlich Willkommen zum Memory-Spiel.");
            Console.WriteLine(
                "Beim Memory-Spiel für Einzelspieler werden alle Symbole verdeckt und der Spieler " +
                "klickt aufs Symbol, um Paare mit identischen Symbolen zu finden. Das Ziel ist es, alle Paare " +
                "mit möglichst wenigen Versuchen zu finden und sich dabei die Positionen der Symbolen zu merken. ");
            Console.WriteLine("Hinter den '?' verstecken sich Symbole, die paarweise vorkommen. Fiden Sie diese!");
            Console.WriteLine("Wählen Sie zwei Positionen zum Aufdecken in der Form: Zeile1Spalte1Zeile2Spalte2,");
            Console.WriteLine(
                "<Bsp. 2142 vergleicht das Symbol in Zeile 2 und Spale 1 mit dem Symbol in Zeile 4 und Spalte 2>");
            Console.WriteLine("  1  2  3  4");
            Console.WriteLine("1 ?  ?  ?  ?");
            Console.WriteLine("2 *  ?  ?  ?");
            Console.WriteLine("3 ?  ?  ?  ?");
            Console.WriteLine("4 ?  *  ?  ?");
        }

        // Aufgabe 4.7
        static void biggest_number()
        {
            List<float> numbers = new List<float>();

            for (int i = 1; i < 12; i++)
            {
                Console.WriteLine("Bitte geben Sie die " + i + ". Zahl ein:");
                string user_input = Console.ReadLine();

                if (float.TryParse(user_input, out float num))
                {
                    numbers.Add((num));
                }
                else
                {
                    Console.WriteLine("Das ist keine Zahl!");
                    return;
                }
            }

            if (numbers.Count > 0)
            {
                float maxNum = numbers.Max();
                Console.WriteLine("Die grösste Zahl ist: " + maxNum);
            }
            else
            {
                Console.WriteLine("Keine gültigen Zahlen eingegeben");
            }
        }
        
        // Aufgabe 4.8
        static void random_comma_numbers()
        {
            Random random = new Random();
            Console.WriteLine("Starten Sie das Generieren der Zufallszahlen mit der Enter-Taste...");
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            double biggestNumber = double.MinValue;
            double biggestNumber2 = double.MinValue;
            double biggestNumber3 = double.MinValue;
            double biggestNumber4 = double.MinValue;
            double biggestNumber5 = double.MinValue;
            if (keyInfo.Key == ConsoleKey.Enter)
            {
                for (int row = 0; row < 5; row++)
                {
                    
                    for (int col = 0; col < 5; col++)
                    {
                        double wholeNumber = random.Next(1,100);
                        double decimalPart = random.NextDouble();
                        double number = wholeNumber + decimalPart;
                        string formattedNumber = ($"   {number,-10:0.####################}");
                        Console.Write($"{formattedNumber}");

                        if (col ==  0 && number > biggestNumber)
                        {
                            biggestNumber = number;
                        }
                        if (col ==  1 && number > biggestNumber2)
                        {
                            biggestNumber2 = number;
                        }
                        if (col ==  2 && number > biggestNumber3)
                        {
                            biggestNumber3 = number;
                        }
                        if (col ==  3 && number > biggestNumber4)
                        {
                            biggestNumber4 = number;
                        }
                        if (col ==  4 && number > biggestNumber5)
                        {
                            biggestNumber5 = number;
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                
                Console.WriteLine($"Das Maximum der 1. Zeile ist : {biggestNumber}");
                Console.WriteLine($"Das Maximum der 2. Zeile ist : {biggestNumber2}");
                Console.WriteLine($"Das Maximum der 3. Zeile ist : {biggestNumber3}");
                Console.WriteLine($"Das Maximum der 4. Zeile ist : {biggestNumber4}");
                Console.WriteLine($"Das Maximum der 5. Zeile ist : {biggestNumber5}");
            }
        }

        static void GCD(int num1, int num2)
        {
            
        }
    }
}