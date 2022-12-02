namespace Puzzle_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Puzzle1();
            Puzzle2();
        }

        private static void Puzzle1()
        {
            var input = File.ReadAllLines("input.txt");

            int Highestcalories = 0;
            int currentCalories = 0;

            foreach (var item in input)
            {
                if (string.IsNullOrEmpty(item))
                {
                    if(currentCalories > Highestcalories)
                        Highestcalories= currentCalories;

                    currentCalories = 0;
                    continue;
                }

                if (int.TryParse(item, out int calorieUnit))
                    currentCalories += calorieUnit;
            }

            Console.WriteLine(Highestcalories);
        }

        private static void Puzzle2()
        {
            var input = File.ReadAllLines("input.txt");

            int currentCalories = 0;
            int[] top3Calories = new int[3];

            foreach (var item in input)
            {
                if (string.IsNullOrEmpty(item))
                {
                    if (currentCalories > top3Calories[0])
                    {
                        top3Calories[2] = top3Calories[1];
                        top3Calories[1] = top3Calories[0];
                        top3Calories[0] = currentCalories;
                    }
                    else if (currentCalories > top3Calories[1])
                    {
                        top3Calories[2] = top3Calories[1];
                        top3Calories[1] = currentCalories;
                    }
                    else if (currentCalories > top3Calories[0])
                    {
                        top3Calories[2] = currentCalories;
                    }

                    currentCalories = 0;
                    continue;
                }

                if (int.TryParse(item, out int calorieUnit))
                    currentCalories += calorieUnit;
            }

            Console.WriteLine(top3Calories.Sum());
        }
    }
}