using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            
            testing();
        }

        // FUNKTIONEN / METHODEN
        static void DrawSquare(int count)
        {
            for (int j = 0; j < count; j++)
            {
                for (int i = 0; i < count; i++)
                {
                    Console.Write("\u2663");
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
            Console.WriteLine("<Bsp. 2142 vergleicht das Symbol in Zeile 2 und Spale 1 mit dem Symbol in Zeile 4 und Spalte 2>");
            Console.WriteLine("  1  2  3  4");
            Console.WriteLine("1 ?  ?  ?  ?");
            Console.WriteLine("2 *  ?  ?  ?");
            Console.WriteLine("3 ?  ?  ?  ?");
            Console.WriteLine("4 ?  *  ?  ?");
        }

        // Aufgabe 4.7
        static void biggest_number()
        {
            Console.WriteLine("Bitte geben Sie eine 1. Zahl ein: ");
            
        }
        
        
        
        
        
        
        
        
        
        
        static void testing()
        {
            int[] biggest_num = {1,5,7,9,8};
            if (biggest_num[1] > biggest_num[4])
            {
                Console.WriteLine("Das erste ist grösser");
            }
            else
            {
                Console.WriteLine("nö");
            }
        }
    }
}