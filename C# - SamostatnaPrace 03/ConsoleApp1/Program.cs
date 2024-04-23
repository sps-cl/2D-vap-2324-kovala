using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        //Statické proměnné pro uchování seznamu slov a aktuálního slova
        static LinkedList<string> wordsList = new LinkedList<string>(); //Seznam slov
        static LinkedListNode<string> currentWord = null; //Aktuální slovo

        static void Main(string[] args)
        {
            while (true) //Nekonečná smyčka pro vkládání příkazů
            {
                Console.Write("Zadejte příkaz: ");
                string input = Console.ReadLine().Trim();//Čtení vstupu od uživatele

                string[] parts = input.Split(':'); //Rozdělení vstupu na příkaz a argument
                if (parts.Length == 2) // Pokud jsou dva oddělené části (příkaz a argument)
                {
                    string command = parts[0].Trim().ToLower(); // Příkaz je první částí odděleného vstupu, převedený na malá písmena pro jednodušší porovnání
                    string word = parts[1].Trim(); // Argument je druhou částí odděleného vstupu

                    switch (command) // Rozdělení dle příkazu
                    {
                        case "pridat": // Příkaz pro přidání slova
                            AddWord(word);
                            break;
                        default: // Výchozí případ pro neznámý příkaz
                            Console.WriteLine("Neznámý příkaz.");
                            break;
                    }
                }
                else if (parts.Length == 1) // Pokud je pouze jedna část
                {
                    string command = parts[0].Trim().ToLower();

                    switch (command)
                    {
                        case "zpet": // Příkaz pro přesun zpět v seznamu slov
                            MoveBack(); // Volání metody pro přesun na předchozí slovo
                            break;
                        case "vpred": // Příkaz pro přesun vpřed seznamu slov
                            MoveForward(); // Volání metody pro přesun na následující slovo
                            break;
                        default: // Výchozí případ pro neznámý příkaz
                            Console.WriteLine("Neznámý příkaz."); //Vypsání do konzole, že příkaz je neplatný
                            break;
                    }
                }
                else // Pokud vstup neobsahuje ani jednu dvojtečku nebo více než jednu dvojtečku
                {
                    Console.WriteLine("Neplatný příkaz.");
                }
            }
        }

        static void AddWord(string word) // Metoda pro přidání slova do seznamu
        {
            wordsList.AddLast(word); // Přidání slova na konec seznamu
            currentWord = wordsList.Last; // Nastavení aktuálního slova na poslední přidané slovo
            Console.WriteLine("Slovo '{0}' bylo přidáno.", word); // Výpis potvrzení o přidání slova
            Console.WriteLine("Aktuálně zobrazené slovo: '{0}'", currentWord.Value); // Výpis aktuálně zobrazeného slova
        }

        static void MoveBack() // Metoda pro přesun na předchozí slovo v seznamu
        {
            if (currentWord != null && currentWord.Previous != null)
            {
                currentWord = currentWord.Previous;
                Console.WriteLine("Aktuálně zobrazené slovo: '{0}'", currentWord.Value);
            }
            else 
            {
                Console.WriteLine("Není žádné slovo k zobrazení."); //Vypsání do konzole, že už není žádné slovo, na které se dá vrátit
            }
        }

        static void MoveForward() //Metoda pro přesun na následující slovo v seznamu
        {
            if (currentWord != null && currentWord.Next != null)
            {
                currentWord = currentWord.Next;
                Console.WriteLine("Aktuálně zobrazené slovo: '{0}'", currentWord.Value);
            }
            else
            {
                Console.WriteLine("Není žádné slovo k zobrazení."); //Vypsání do konzole
            }
        }
    }
}
