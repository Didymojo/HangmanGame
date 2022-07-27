namespace HangmanGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hangman");
            Console.WriteLine("------------------");

            Random rnd = new Random();

            List<String> wordList = new List<String>();
            wordList.Add("chemistry"); // adding elements using add() method
            wordList.Add("strike");
            wordList.Add("freighter");
            wordList.Add("provincial");
            wordList.Add("crown");

            int index = rnd.Next(wordList.Count);

            string randomWord = wordList[index];
            Console.WriteLine($"the random word is: {rnd}");

            Console.WriteLine("type your letter guess:");
            string playerGuess = Console.ReadLine();
            Console.WriteLine($"The user chose: {playerGuess}");

            //if (rnd.Contains(playerGuess) == true)  // String.Contains() method returns a value indicating whether a specified substring occurs within this string
            //{
            //    Console.WriteLine("letter found");
            //}
            //else
            //{
            //    Console.WriteLine("letter not found");
            //}


            //    Console.ReadKey();//not sure about how am supposed to use this - it returns the player guess

            int counter = 0;
            int rightLetters = 0;

            foreach (char c in randomWord)
            {
                if (playerGuess.Contains(c))
                {
                    Console.Write(c + " ");
                    rightLetters += 1;
                }
                else
                {
                    Console.Write("- ");
                }
                counter += 1;



            }
        }
    }
}

//    Console.ReadKey();//not sure about how am supposed to use this - it returns the player guess
