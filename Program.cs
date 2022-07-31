namespace HangmanGame
{
    internal class Program
    {
        private static int printWord(List<char> letterGuess, String randomWord)
        {
            int counter = 0;
            int rightLetters = 0;
            Console.Write("\r\n");
            foreach (char c in randomWord)
            {
                if (letterGuess.Contains(c))
                {
                    Console.Write(c + " ");
                    rightLetters += 1;
                }
                else
                {
                    Console.Write("_ ");

                }
                counter += 1;
            }
            return rightLetters;
        }


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
            // Console.WriteLine($"this is the index int: {index}");
            string randomWord = wordList[index];
            Console.WriteLine($"the random word is: {randomWord}");

            foreach (char x in randomWord)
            {
                Console.Write("_ ");
            }

            int numTimesWrong = 0;
            int lengthOfTargetWord = randomWord.Length;
            List<char> lettersAlreadyGuessed = new List<char>();
            int lettersGotRight = 0;
            while (numTimesWrong != 6 && lettersGotRight != lengthOfTargetWord)
            {
                Console.Write("\r\nLetters guessed so far: ");

                foreach (char c in lettersAlreadyGuessed)
                {
                    Console.Write(c + " ");
                }

                Console.Write("\nGuess a letter: \n");
                char letterGuess = Console.ReadLine()[0];

                //check if user has already guessed that letter
                if (lettersAlreadyGuessed.Contains(letterGuess))
                {
                    Console.Write("\r\nYou have already guessed this letter");//\r - carriage return, moves cursor back to beginning of current line
                    lettersGotRight = printWord(lettersAlreadyGuessed, randomWord);
                    Console.Write("\r\n");
                }
                else
                {
                    // Check if letter is in randomWord
                    bool right = false;
                    for (int i = 0; i < randomWord.Length; i++)
                    {
                        if (letterGuess == randomWord[i])
                        {
                            right = true;
                        }
                    }

                    if (right)
                    {
                        lettersAlreadyGuessed.Add(letterGuess);
                        lettersGotRight = printWord(lettersAlreadyGuessed, randomWord);
                        Console.Write("\r\n");
                    }
                    else //are wrong
                    {
                        numTimesWrong += 1;
                        lettersAlreadyGuessed.Add(letterGuess);
                        lettersGotRight = printWord(lettersAlreadyGuessed, randomWord);
                        Console.Write("\r\n");
                    }
                }
            }
            Console.WriteLine("\r\nGame over! Thanks for playing");
        }
    }
}

