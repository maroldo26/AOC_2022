namespace Day_5
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

            var crates = new List<List<char>>
            {
                new List<char> {'B','L','D','T','W','C','F','M'},
                new List<char> {'N','B','L'},
                new List<char> {'J','C','H','T','L','V'},
                new List<char> {'S','P','J','W'},
                new List<char> {'Z','S','C','F','T','L','R'},
                new List<char> {'W','D','G','B','H','N','Z'},
                new List<char> {'F','M','S','P','V','G','C','N'},
                new List<char> {'W','Q','R','J','F','V','C','Z',},
                new List<char> {'R','P','M','L','H'}
            };

            for (int lineIndex = 10; lineIndex < lines.Length; lineIndex++)
            {
                string operation = lines[lineIndex];

                int startIndex = 4;
                int length = operation.IndexOf("from") - startIndex;

                int count = int.Parse(operation.Substring(startIndex, length).Trim());

                startIndex = operation.IndexOf("from") + 5;
                length = operation.IndexOf("to") - startIndex;
                int from = int.Parse(operation.Substring(startIndex , length).Trim());

                startIndex = operation.IndexOf("to") + 3;
                length = operation.Length - startIndex;
                int to = int.Parse(operation.Substring(startIndex, length));

                for (int i = count; i > 0; i--)
                {
                    var sourceCrate = crates[from - 1];
                    var targetCrate = crates[to - 1];

                    targetCrate.Add(sourceCrate[sourceCrate.Count - 1]);
                    sourceCrate.RemoveAt(sourceCrate.Count - 1);
                }
            }

            foreach (var crate in crates)
            {
                Console.Write(crate[crate.Count -1]);
            }

        }

        private static void Puzzle2()
        {
            var lines = File.ReadAllLines("Input.txt");

            var crates = new List<List<char>>
            {
                new List<char> {'B','L','D','T','W','C','F','M'},
                new List<char> {'N','B','L'},
                new List<char> {'J','C','H','T','L','V'},
                new List<char> {'S','P','J','W'},
                new List<char> {'Z','S','C','F','T','L','R'},
                new List<char> {'W','D','G','B','H','N','Z'},
                new List<char> {'F','M','S','P','V','G','C','N'},
                new List<char> {'W','Q','R','J','F','V','C','Z',},
                new List<char> {'R','P','M','L','H'}
            };

            for (int lineIndex = 10; lineIndex < lines.Length; lineIndex++)
            {
                string operation = lines[lineIndex];

                int startIndex = 4;
                int length = operation.IndexOf("from") - startIndex;

                int count = int.Parse(operation.Substring(startIndex, length).Trim());

                startIndex = operation.IndexOf("from") + 5;
                length = operation.IndexOf("to") - startIndex;
                int from = int.Parse(operation.Substring(startIndex, length).Trim());

                startIndex = operation.IndexOf("to") + 3;
                length = operation.Length - startIndex;
                int to = int.Parse(operation.Substring(startIndex, length));

                var sourceCrate = crates[from - 1];
                var targetCrate = crates[to - 1];

                int startRange = sourceCrate.Count - count;
                int totalItemsToMove = sourceCrate.Count;

                for (int i = startRange; i < totalItemsToMove; i++)
                {
                    targetCrate.Add(sourceCrate[startRange]);
                    sourceCrate.RemoveAt(startRange);
                }                
            }

            foreach (var crate in crates)
            {
                Console.Write(crate[crate.Count - 1]);
            }

        }
    }
}