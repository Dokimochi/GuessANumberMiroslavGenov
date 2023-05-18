Random random = new Random();
int randomNumber = random.Next(1, 101);

while (true)
{
    Console.Write("Guess a number (1 - 100): ");
    string input = Console.ReadLine();

    bool isValid = int.TryParse(input, out int playerNumber);

    if (isValid)
    {
        if (randomNumber == playerNumber)
        {
            Console.WriteLine("You guessed it!");
            break;
        }
        else if (randomNumber < playerNumber)
        {
            Console.WriteLine("Too High!");
            continue;
        }
        else if (randomNumber > playerNumber)
        {
            Console.WriteLine("Too Low!");
            continue;
        }
    }
    else
    {
        Console.WriteLine("Wrong input!");
        continue;
    }
}