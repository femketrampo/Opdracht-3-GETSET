using System;
using System.Collections;
using System.Collections.Generic;

namespace Opdracht_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<CD> Liedjes = new List<CD>();
            int keuze;
            string antwoord;

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;

                Console.WriteLine("1) Geef nieuw liedje in.");
                Console.WriteLine("2) Geef CD weer.");
                Console.WriteLine("3) Exit.");
                Console.Write("Keuze: ");
                keuze = Convert.ToInt32(Console.ReadLine());

                if (keuze <= 3)
                {
                    switch (keuze)
                    {
                        case 1:
                            {
                                do
                                {
                                    Liedjes.Add((Song()));

                                    Console.Write("Wilt u nog een liedje toevoegen?(J/N): ");
                                    antwoord = Console.ReadLine();
                                } while (antwoord.ToUpper() == "J");
                            }
                            break;

                        case 2:
                            {
                                CD(Liedjes);
                                Console.ReadLine();
                            }
                            break;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Dit is geen geldige optie!");
                    Console.ReadLine();
                }
            } while (keuze != 3);
        }

        private static CD Song()
        {
            Console.Clear();
            CD cd = new CD();

            Console.Write("Geef de titel in: ");
            cd.Titel = Console.ReadLine();
            Console.Write("Geef de uitvoerder in: ");
            cd.Uitvoerder = Console.ReadLine();

            return cd;
        }
        private static void CD(List<CD> Liedjes)
        {
            if (Liedjes.Count == 0)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;

                Console.WriteLine("Er zijn nog geen liedjes ingegeven!");
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("Liedjes:\n");

                int Teller = 1;

                foreach (CD Cd in Liedjes)
                {
                    Console.WriteLine("{0}: {1} - {2}", Teller, Cd.Titel, Cd.Uitvoerder);
                    Teller++;

                    //REMEMBER!!
                    //Optie 2: (check class)

                    //Console.WriteLine(Teller + ": " +Cd);
                    //Teller++;
                }
            }
        }
    }
}
