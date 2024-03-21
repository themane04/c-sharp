using System;
using System.ComponentModel;
using System.Collections.Generic;


namespace memory_game
{
    internal class Memory
    {
        static int size = 4;
        static char[] symbols = { '☺', '☻', '♦', '♠', '♥', '♣', '♫', '☼', '©', '&', '▲', '►', '▼', '◄', '#', '§', '$', '£' };

        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Show_Manual();


            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Das Spiel beginnt");
            Console.WriteLine();

            char[,] Shown = new char[size, size];
            char[,] Content = new char[size, size];
            FullShow(Shown);
            FillInMemory(Content);

            while (!IsGameOver(Shown))
            {
                Show(Shown);

                Console.WriteLine("Geben Sie die Positionen der Symbole ein (z.B. 1234): ");
                string input = Console.ReadLine();
                char[] charInput = input.ToCharArray();

                if (InputCheck(charInput, size))
                {
                    int x1 = charInput[0] - '0' - 1;
                    int y1 = charInput[1] - '0' - 1;
                    int x2 = charInput[2] - '0' - 1;
                    int y2 = charInput[3] - '0' - 1;

                    if (x1 == x2 && y1 == y2)
                    {
                        Console.WriteLine("Ungültige Eingabe. Geben Sie bitte 2 unterschiedliche Felder ein.");
                    }
                    else
                    {
                        OpenCover(Shown, Content, x1, y1, x2, y2);
                        CompareSymbols(Shown, Content, x1, y1, x2, y2);
                        HideMemory(Shown);
                    }
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe");
                }
            }

            Console.WriteLine("Herzlichen Glückwunsch, Sie haben das Spiel gewonnen!");
            Console.WriteLine("Drücken Sie eine beliebige Taste, um das Spiel zu beenden.");
            Console.ReadKey();

        }  

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

        static bool InputCheck(char[] input, int size)
        {
            if (input.Length != 4) return false;

            int X1 = input[0] - '0';
            int Y1 = input[1] - '0';
            int X2 = input[2] - '0';
            int Y2 = input[3] - '0';

            return X1 >= 1 && X1 <= size && Y1 >= 1 && Y1 <= size && 
                    X2 >= 1 && X2 <= size && Y2 >= 1 && Y2 <= size;
        }

        static void FullShow(char[,] ar)
        {
            for (int i = 0; i < ar.GetLength(0); i++)
            { 
                for (int j = 0; j < ar.GetLength(1); j++)
                {
                    ar[i, j] = '?';
                }
            }
        }

        static void Show(char[,] ar)
        {
            Console.WriteLine("  1 2 3 4");
            for (int i = 0;i < ar.GetLength(0); i++)
            {
                Console.Write((i + 1) + " ");
                for (int j = 0;j < ar.GetLength(1); j++) 
                {
                    Console.Write(ar[i,j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void FillInMemory(char[,] ar)
        {
            Random rnd = new Random();
            List<char> availableSymbols = new List<char>(symbols).GetRange(0, (size * size) / 2);
            List<Tuple<int, int>> positions = new List<Tuple<int, int>>();

            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    positions.Add(new Tuple<int, int>(i, j));

            foreach (char symbol in availableSymbols)
            {
                for (int i = 0; i < 2; i++) // each symbol appears twice
                {
                    int posIndex = rnd.Next(positions.Count);
                    var pos = positions[posIndex];
                    positions.RemoveAt(posIndex);
                    ar[pos.Item1, pos.Item2] = symbol;
                }
            }
        }

        static void CompareSymbols(char[,] ar1, char[,] ar2, int x1, int y1, int x2, int y2)
        {
            if (ar2[x1, y1] == ar2[x2, y2])
            {
                Console.WriteLine("Treffer, Super!");
                ar1[x1, y1] = ' ';
                ar1[x2, y2] = ' ';
            }
            else
            {
                Console.WriteLine("Leider kein Treffer.");
            }
        }

        static void OpenCover(char[,] ar1, char[,] ar2, int x1, int y1, int x2, int y2)
        {
            if (ar1[x1, y1] == '?' && ar1[x2, y2] == '?')
            {
                ar1[x1, y1] = ar2[x1, y1];
                ar1[x2, y2] = ar2[x2, y2];
                Show(ar1);
            }
            else
            {
                Console.WriteLine("Diese/s Feld/er wurde/n bereits aufgedeckt. Bitte wählen Sie andere Felder/ein anderes Feld.");
            }
        }


        static void HideMemory(char[,] ar1)
        {
            for (int i = 0; i < ar1.GetLength(0); i++)
            {
                for (int j = 0; j < ar1.GetLength(1); j++)
                {
                    if (ar1[i, j] != ' ')
                    {
                        ar1[i, j] = '?';
                    }
                }
            }
        }

        static bool IsGameOver(char[,] ar)
        {
            for (int i = 0; i < ar.GetLength(0); i++)
            {
                for (int j = 0; j < ar.GetLength(1); j++)
                {
                    if (ar[i, j] == '?')
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}