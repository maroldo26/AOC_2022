namespace Day_4
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
            int totalPairs = 0;

            foreach (var line in lines)
            {
                var pairs = line.Split(',');

                string[] pair1Values = pairs[0].Split('-');
                string[] pair2Values = pairs[1].Split('-');

                int pair1StartValue = int.Parse(pair1Values[0]);
                int pair1EndValue = int.Parse(pair1Values[1]);

                int pair2StartValue = int.Parse(pair2Values[0]);
                int pair2EndValue = int.Parse(pair2Values[1]);

                if((pair2StartValue >= pair1StartValue && pair2EndValue <= pair1EndValue) ||
                    (pair1StartValue >= pair2StartValue && pair1EndValue <= pair2EndValue))
                {
                    totalPairs++;
                }

            }

            Console.WriteLine(totalPairs);
        }

        private static void Puzzle2()
        {
            var lines = File.ReadAllLines("Input.txt");
            int totalPairs = 0;

            foreach (var line in lines)
            {
                var pairs = line.Split(',');

                string[] pair1Values = pairs[0].Split('-');
                string[] pair2Values = pairs[1].Split('-');

                int pair1StartValue = int.Parse(pair1Values[0]);
                int pair1EndValue = int.Parse(pair1Values[1]);

                int pair2StartValue = int.Parse(pair2Values[0]);
                int pair2EndValue = int.Parse(pair2Values[1]);

                if ((pair2StartValue >= pair1StartValue && pair2EndValue <= pair1EndValue) ||
                    (pair1StartValue >= pair2StartValue && pair1EndValue <= pair2EndValue))
                {
                    totalPairs++;
                }
                else if ((pair2StartValue >= pair1StartValue && pair2StartValue <= pair1EndValue) || 
                    (pair2EndValue >= pair1StartValue && pair2EndValue <= pair1EndValue))
                {
                    totalPairs++;
                }
                else
                {
                    Console.WriteLine(line);
                }

            }

            Console.WriteLine(totalPairs);
        }
    }
}