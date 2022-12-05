using System.Reflection.Emit;

namespace Day_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Puzzle2();
        }

        private static void Puzzle1()
        {
            var lines = File.ReadAllLines("Input.txt");

            int lineCount = lines.Count();
            char[] sameItems = new char[lines.Count()];

            for (int lineIndex  = 0; lineIndex < lineCount; lineIndex++)
            {
                string line = lines[lineIndex];
                int compartmentLength = line.Length / 2;
                char commonItem = '\0';

                for (int i = 0; i < compartmentLength; i++)
                {
                    for (int j = compartmentLength; j < line.Length; j++)
                    {
                        if (line[i] == line[j])
                        {
                            commonItem = line[j];
                            break;
                        }
                    }

                    if (commonItem != '\0')
                        break;
                }

                sameItems[lineIndex] = commonItem;
            }

            int total = 0;

            foreach (var item in sameItems)
            {
                if(item >= 65 && item <= 90)
                {
                    total += item - 38;
                }
                else if(item >= 97 && item <= 122)
                {
                    total += item - 96;
                }
            }

            Console.WriteLine(total);
        }

        private static void Puzzle2()
        {
            var lines = File.ReadAllLines("Input.txt");

            int totalGroup = lines.Count() / 3;
            char[] sameItems = new char[totalGroup];
            int step = 0;

            for (int i = 0; i < totalGroup; i++)
            {
                string ruckSack1 = lines[step++];
                string ruckSack2 = lines[step++];
                string ruckSack3 = lines[step++];

                for (int sack1 = 0; sack1 < ruckSack1.Length; sack1++)
                {
                    for (int sack2 = 0; sack2 < ruckSack2.Length; sack2++)
                    {
                        if (ruckSack1[sack1] == ruckSack2[sack2])
                        {
                            for (int sack3 = 0; sack3 < ruckSack3.Length; sack3++)
                            {
                                if (ruckSack2[sack2] == ruckSack3[sack3])
                                {
                                    sameItems[i] = ruckSack1[sack1];
                                    goto additem;
                                }
                            }
                        }
                    }

                    additem:
                    continue;
                }
            }

            int total = 0;

            foreach (var item in sameItems)
            {
                if (item >= 65 && item <= 90)
                {
                    total += item - 38;
                }
                else if (item >= 97 && item <= 122)
                {
                    total += item - 96;
                }
            }

            Console.WriteLine(total);
        }
    }
}