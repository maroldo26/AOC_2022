namespace Day_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Puzzle_1();
            Puzzle_2();
        }

        private static void Puzzle_1()
        {
            var input = File.ReadAllLines("Input.txt");

            int totalScore = 0;

            foreach (var item in input)
            {
                if (item.Length < 3)
                    continue;

                char opponetChoice = item[0];
                char myChoice = item[2];

                int opponentScore = 0, myScore = 0;

                opponentScore = opponetChoice == 'A' ? 1 : opponetChoice == 'B' ? 2 : 3;
                myScore = myChoice == 'X' ? 1 : myChoice == 'Y' ? 2 : 3;

                int result = 0;

                // Draw
                // Rock vs Paper => Player 2 wins
                // Rock vs Scissors => Player 1 wins
                // Paper vs Rock=> Player 1 wins
                // Paper vs Scissors=> Player 2 wins
                // Scissors vs Rock=> Player 2 wins
                // Scissors vs Paper=> Player 1 wins

                if (opponentScore == myScore ) 
                {
                    result = 3;
                }
                else if((opponentScore == 1 && myScore == 2)|| (opponentScore == 2 && myScore == 3) ||
                    (opponentScore == 3 && myScore == 1))// Rock vs Paper
                {
                    result= 6;
                }

                totalScore+= (result + myScore);
            }

            Console.WriteLine(totalScore);
        }

        private static void Puzzle_2()
        {
            var input = File.ReadAllLines("Input.txt");

            int totalScore = 0;

            foreach (var item in input)
            {
                if (item.Length < 3)
                    continue;

                char opponetChoice = item[0];
                char myChoice = item[2];

                int opponentScore = 0, myScore = 0;

                opponentScore = opponetChoice == 'A' ? 1 : opponetChoice == 'B' ? 2 : 3;
                
                int result = myChoice == 'X' ? 0 : myChoice == 'Y' ? 3 : 6;


                // 1 = Lose, 2 = Draw, 3 = Win

                if (result == 3)
                {
                    myScore = opponentScore;
                }
                else if(result == 0) // Lose
                {
                    myScore = opponetChoice == 'A' ? 3 : opponetChoice == 'B' ? 1 : 2;
                }
                else if(result == 6) // Win
                {
                    myScore = opponetChoice == 'A' ? 2 : opponetChoice == 'B' ? 3 : 1;
                }

                totalScore += (result + myScore);
            }

            Console.WriteLine(totalScore);
        }
    }
}