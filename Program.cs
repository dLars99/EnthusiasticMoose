using System;

namespace EnthusiasticMoose
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();

            // Let the moose speak!
            MooseSays("H I, I'M  E N T H U S I A S T I C !");
            MooseSays("Hey Rocky, watch me pull a rabbit out of my hat!");

            // Ask some questions
            Question("Is Canada real?", "Really? It seems very unlikely.", "I  K N E W  I T !!!");
            Question("Are you enthusiastic?", "Yay!", "You should try it!");
            Question("Do you love C# yet?", "Good job sucking up to your instructor!", "You will...oh, yes, you will...");
            Question("Do you want to know a secret?", "ME TOO!!!! I love secrets...tell me one!", "Oh, no...secrets are the best, I love to share them!");
        }

        static void Question(string question, string yes, string no)
        {
            bool isTrue = MooseAsks(question);
            if (isTrue)
            {
                Console.Clear();
                MooseSays(yes);
            }
            else
            {
                Console.Clear();
                MooseSays(no);
            }
        }

        static bool MooseAsks(string question)
        {
            Console.Write($"{question} (Y/N): ");
            string answer = Console.ReadLine().ToLower();

            while (answer != "y" && answer != "n")
            {
                Console.Write($"{question} (Y/N): ");
                answer = Console.ReadLine().ToLower();
            }

            Console.Clear();

            return (answer == "y");
        }

        static void MooseSays(string message)
        {
            Console.WriteLine($@"
                                      _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
        }
    }

    public class Question
    {
        public string Request { get; set; }
        public string Yes { get; set; }
        public string No { get; set; }
    }
}