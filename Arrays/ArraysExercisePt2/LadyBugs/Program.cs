using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] ladybugSpaces = Console.ReadLine().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] field = new int[fieldSize];

            for (int i = 0; i < fieldSize; i++)
            {
                if (ladybugSpaces.Contains(i))
                {
                    field[i] = 1;
                }
            }

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] command = input.Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries).ToArray();

                int initialPosition = int.Parse(command[0]);
                string direction = command[1];
                int countOfMoves = int.Parse(command[2]);

                int newPosition = 0;

                if (countOfMoves < 0)
                {
                    if (direction == "right")
                    {
                        direction = "left";
                        countOfMoves = Math.Abs(countOfMoves);
                    }
                    else if (direction == "left")
                    {
                        direction="right";
                        countOfMoves=Math.Abs(countOfMoves);
                    }
                }

                if (initialPosition < 0 || initialPosition > field.Length - 1|| field[initialPosition] == 0)
                {
                    input = Console.ReadLine();
                    continue;
                }

                if (countOfMoves == 0 && initialPosition >= 0 && initialPosition <= field.Length)
                {
                    if (field[initialPosition] == 1)
                    {
                        field[initialPosition] = 0;
                    }
                }

                if (direction == "right")
                {
                    newPosition = initialPosition + countOfMoves;
                    field[initialPosition] = 0;

                    if (newPosition > field.Length- 1)
                    {
                        field[initialPosition] = 0;
                    }
                    else
                    {
                        for (int i = newPosition; i < field.Length; i += countOfMoves)
                        {
                            if (field[i] == 0)
                            {
                                field[i] = 1;
                                break;
                            }
                        }
                    }
                }
                else if (direction == "left")
                {
                    newPosition = initialPosition - countOfMoves;

                    field[initialPosition] = 0;
                    
                    if (newPosition < 0)
                    {
                        field[initialPosition] = 0;
                    }
                    else
                    {
                        for (int i = newPosition; i >= 0; i-= countOfMoves)
                        {
                            if (field[i] == 0)
                            {
                                field[i] = 1;
                                break;
                            }
                        }
                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ", field));
        }
    }
}
