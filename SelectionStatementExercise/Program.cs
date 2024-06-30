namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Number Guessing Game
            var r = new Random();
            //var favNumber = r.Next(1, 1000);
            var favNumber = 5;
            int userInput;
            var counter = 0;

            do
            {

                Console.WriteLine("Pick a number from 1 - 1000");
                userInput = int.Parse(Console.ReadLine());

                if (userInput < favNumber)
                {
                    Console.WriteLine($"{userInput} is too low");
                }
                else if (userInput > favNumber)
                {
                    Console.WriteLine($"{userInput} is too high");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
                counter++;

                Console.WriteLine($"You have guessed{counter} times!");
            }
            while (userInput != favNumber);

            //Switch-case
            Console.WriteLine($"What is your favorite subject?");

            string subject = Console.ReadLine();

            switch (subject.ToLower)
            {
                case "Math":
                    Console.WriteLine("I hate math!");
                    break;
                case "science":
                    Console.WriteLine($"I love science");
                    break;
                case "pe":
                    Console.WriteLine("PE is the best!");
                    break;
                case "history":
                    Console.WriteLine("English is boring");
                    break;
                case "english":
                    Console.WriteLine("English is boring");
                    break;
                default:
                    Console.WriteLine("I dont know that subject");
                    break;
            }
    }
}
