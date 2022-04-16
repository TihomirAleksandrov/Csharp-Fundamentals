using System;
using System.Linq;
using System.Collections.Generic;

namespace CardsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> deck1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> deck2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            GetWinner(deck1, deck2);
        }

        static void GetWinner(List<int> deck1, List<int> deck2)
        {
            while (true)
            {
                if (deck1.Count == 0 || deck2.Count == 0)
                {
                    break;
                }
                
                if (deck1[0] > deck2[0])
                {
                    deck1.Add(deck1[0]);
                    deck1.Add(deck2[0]);
                    deck1.RemoveAt(0);
                    deck2.RemoveAt(0);
                }
                else if (deck1[0] < deck2[0])
                {
                    deck2.Add(deck2[0]);
                    deck2.Add(deck1[0]);
                    deck1.RemoveAt(0);
                    deck2.RemoveAt(0);
                }
                else if (deck1[0] == deck2[0])
                {
                    deck1.RemoveAt(0);
                    deck2.RemoveAt(0);
                }
            }

            int sum = 0;

            if (deck1.Count > deck2.Count)
            {
                sum = GetSum(deck1);
                Console.WriteLine($"First player wins! Sum: {sum}");
            }
            else
            {
                sum = GetSum(deck2);
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }
        }

        static int GetSum(List<int> winningDeck)
        {
            int sum = 0;
            
            for (int i = 0; i < winningDeck.Count; i++)
            {
                sum += winningDeck[i];
            }

            return sum;
        }
    }
}
