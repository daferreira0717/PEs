/*
 * Dante Ferreira - 09/29/25 - For Loops
 * Demonstrate the use of multiple loops
 */
main();
void main()
{
    Console.Write("0 - 10 For:  ");
    for(int i = 0; i < 11; i++)
    {
        Console.Write(i + " ");
    }
    Console.Write("\n\n100 - 90 For:  ");
    for(int i = 100; i > 89; i--)
    {
        Console.Write(i + " ");
    }
    Console.Write("\n\nMultiples of 5 For:  ");
    for(int i = 0; i < 51; i++)
    {
        if(i%5 == 0)
        {
            Console.Write(i + " ");
        }
    }
    Console.Write("\n\nDashed letters of a string:  ");
    string word = "Coding";
    for (int i = 0; i < word.Length; i++)
    {
        if (i == word.Length - 1)
        {
            Console.Write(word[i]);
        }
        else
        {
            Console.Write(word[i] + "-");
        }
    }
    Console.WriteLine("\n\nEvens and Odds: ");
    for(int i = 2; i < 8; i++)
    {
        if(i % 2 == 0)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(i + " even");
        } else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(i + " odd");
        }
    }
    Console.ForegroundColor = ConsoleColor.White;

    Console.Write("\nEnter a width (3 or more): ");
    int width = Convert.ToInt32(Console.ReadLine());
    bool widthValid = false;
   while (!widthValid)
    {
        if (width >= 3)
        {
            widthValid = true;
        } else
        {
            Console.Write("Oops! Number must be 3 or greater. Enter a width: ");
            width = Convert.ToInt32(Console.ReadLine()); 
        }
    }

    Console.Write("\nEnter a height (3 or more): ");
    int height = Convert.ToInt32(Console.ReadLine());
    bool heightValid = false;
    while (!heightValid)
    {
        if (height >= 3)
        {
            heightValid = true;
        }
        else
        {
            Console.Write("Oops! Number must be 3 or greater. Enter a height: ");
            height = Convert.ToInt32(Console.ReadLine());   
        }
    }
    for(int i = 0; i < height; i++)
    {
        for(int k = 0; k < width; k++)
        {
            Console.Write("X");
        }
        Console.Write("\n");
    }
    Console.WriteLine("");
    for (int i = 0; i < height; i++)
    {
        for (int k = 0; k < width; k++)
        {
            if(i == 0 || i == height - 1)
            {
                Console.Write("X");
            } else if (k == 0 || k == width - 1)
            {
                Console.Write("X");
            } else
            {
                Console.Write(" ");
            }            
        }
        Console.Write("\n");
    }
}