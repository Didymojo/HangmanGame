namespace HangmanGame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> wordList = new List<string>();

            wordList.Add("chemistry");
            wordList.Add("strike");
            wordList.Add("provincial");
            wordList.Add("crown");
            wordList.Add("freighter");
  

            Random rng = new Random();
            int index = rng.Next(wordList.Count);

            Console.WriteLine(wordList[index]);  //prints the random word

            Console.WriteLine("type your letter guess:");
            string playerGuess = Console.ReadLine();
            Console.WriteLine($"The user chose: {playerGuess}");

            //next part is to find or write a function that helps find out if character is part of a string, 

            string s = "coding is hard";


            if (s.Contains(playerGuess) == true) //contains wont work for the integer, if the random word is chosen using the integer
            {
                Console.WriteLine("letter found");
            }
            else
            {
                Console.WriteLine("letter NOT found");
            }


            //Console.WriteLine(randomWord);



            // Console.WriteLine(wordSelection[0] + wordSelection[1]);


            //int randIndex = rnd.Next(wordList.Count);
            //int random = wordList[randIndex];

            //get the person to enter a word, is that word in the array, if not then print one of those lines:
            //Console.WriteLine("Type your word guess:");
            //string playerGuess = Console.ReadLine();




            //  console.writeline("  +---+\n  |   |\n      |\n      |\n      |\n      |\n=========\n" +

            //"  +---+\n  |   |\n  o   |\n      |\n      |\n      |\n=========\n" +

            //"  +---+\n  |   |\n  o   |\n  |   |\n      |\n      |\n=========\n" +

            //"  +---+\n  |   |\n  o   |\n /|   |\n      |\n      |\n=========\n" +

            //"  +---+\n  |   |\n  o   |\n /|\\  |\n      |\n      |\n=========\n" +

            //"  +---+\n  |   |\n  o   |\n /|\\  |\n /    |\n      |\n=========\n" +

            //"  +---+\n  |   |\n  o   |\n /|\\  |\n / \\  |\n      |\n=========\n)");
        }
    }
}