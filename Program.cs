Console.WriteLine("b = blue, r = red, g = green, y = yellow");
int x = Console.Read();
char userInput = Convert.ToChar(x);

while (userInput != 'z')
{
    switch (userInput)
    {
        case 'b':
            Console.BackgroundColor = ConsoleColor.Blue;
            break;
        case 'g':
            Console.BackgroundColor = ConsoleColor.Green;
            break;
        case 'r':
            Console.BackgroundColor = ConsoleColor.Red;
            break;
        case 'y':
            Console.BackgroundColor = ConsoleColor.Yellow;
            break;
        default:
            Console.BackgroundColor = ConsoleColor.Black;
            break;
    }
    Console.Clear();
    Console.WriteLine("b = blue, r = red, g = green, y = yellow");
    x = Console.Read();
    userInput = Convert.ToChar(x);
}
