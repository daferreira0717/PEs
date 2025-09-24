main();
void main()
{
    // ------------------------------------------------------------------------------------
    // Variable block
    // The program must use all of these variables.  
    // Students may add any variables deemed necessary to this block. 
    // ------------------------------------------------------------------------------------

    // Used for retrieving the player's provided data
    string userInput = "";
    int userChosenItem = 0;
    int userChosenQuantity = 0;

    // Store the name and cost of all items in the shop
    const string item_healingPotion = "Healing Potion";
    const string item_shield = "Shield";
    const string item_sword = "Sword";
    const string item_armor = "Armor";
    const double cost_healingPotion = 10.50;
    const double cost_shield = 40.0;
    const double cost_sword = 50.25;
    const double cost_armor = 100.99;

    // Used to hold the player's chosen item
    string item_selected = "";
    double cost_selected = 0;


    // ------------------------------------------------------------------------------------
    // Welcome to the shop
    // ------------------------------------------------------------------------------------
    // EXPECTED OUTPUTS:
    //
    // Welcome to the Monster Hunter Shop! 
    // Do you wish to continue? Yes             <-- Yes or Y 
    // Excellent! Let’s go shopping!
    // << Program continues! >>
    //
    // Welcome to the Monster Hunter Shop! 
    // Do you wish to continue? No              <-- No or N
    // Exiting the shop. Thanks for stopping by!
    // << Program exits! >>
    //
    // Welcome to the Monster Hunter Shop! 
    // Do you wish to continue? I don't know    <-- Any other inputs
    // I don’t understand... Thanks for stopping by!
    // << Program exits! >>

    Console.WriteLine("Welcome to the Monster Hunter Shop!");
    Console.Write("Do you wish to continue? ");
    userInput = Console.ReadLine()!.Trim().ToUpper();

    // TODO: Write conditions to display appropriate console output. End game where needed.
    if(userInput == "Yes" || userInput == "Y")
    {
        Console.WriteLine("\nExcellent! Let’s go shopping!");
    }
    else if(userInput == "N" || userInput == "No")
    {
        Console.WriteLine("\nExiting the shop. Thanks for stopping by!");
    }
    else
    {
        Console.WriteLine("\nI don’t understand... Thanks for stopping by!");
    }


    // ------------------------------------------------------------------------------------
    // Display a menu of items in the shop
    // ------------------------------------------------------------------------------------
    // EXPECTED OUTPUT:
    //
    // Here are my goods for sale:
    // 1. Healing Potion - $10.50
    // 2. Shield - $40.00
    // 3. Sword - $50.25
    // 4. Armor - $100.99
    // 5. Changed my mind - exit the shop!
    // ------------------------------------------------------------------------------------

    // TODO: Print items 1 - 4 along with its cost, using string formatting for currency.
    Console.WriteLine("Here are my goods for sale:");
    Console.WriteLine("1. " + item_healingPotion + " - $" + cost_healingPotion);
    Console.WriteLine("2. " + item_shield + " - $" + cost_shield);
    Console.WriteLine("3. " + item_sword + " - $" + cost_sword);
    Console.WriteLine("4. " + item_armor + " - $" + cost_armor);
    Console.WriteLine("5. Changed my mind, exit the shop!");


    // ------------------------------------------------------------------------------------
    // Retrieve the player's chosen item to purchase
    // ------------------------------------------------------------------------------------
    Console.Write("\nPlease enter the number of the item you wish to purchase: ");
    userChosenItem = int.Parse(Console.ReadLine()!);


    // ------------------------------------------------------------------------------------
    // Save the player's choice for future use
    // ------------------------------------------------------------------------------------
    // EXPECTED OUTPUTS:
    //
    // For items 1 - 4: Item name & cost are saved in the appropriate variables. No output.
    //
    // For item 5:
    // "You leave the shop. Thanks for coming by!"
    //
    // For item 6:
    // "I don't recognize that input. You must want a healing potion!"
    // ------------------------------------------------------------------------------------

    // TODO: Write a switch statement to save the selected item and cost
   switch (userChosenItem)
    {
        case 1:
            item_selected = item_healingPotion;
            cost_selected = cost_healingPotion;
            break;
        case 2:
            item_selected = item_shield;
            cost_selected = cost_shield;
            break;
        case 3:
            item_selected = item_sword;
            cost_selected = cost_sword;
            break;
        case 4:
            item_selected = item_armor;
            cost_selected = cost_armor;
            break;
        case 5:
            Console.WriteLine("You leave the shop. Thanks for coming by!");
            break;
        default:
            Console.WriteLine("I don't recognize that input. You must want a healing potion!");
            item_selected = item_healingPotion;
            cost_selected = cost_healingPotion;
            break;
    }


    // ------------------------------------------------------------------------------------
    // Confirm the player's choice
    // ------------------------------------------------------------------------------------
    // EXPECTED OUTPUTS:
    //
    // You selected: Healing Potion with a cost of $10.50
    //
    // You selected: Sword with a cost of $50.25
    // ------------------------------------------------------------------------------------

    // TODO: Format any costs/prices as currency
    Console.WriteLine($"You selected: {item_selected} with a cost of {cost_selected:C2}");


    // ------------------------------------------------------------------------------------
    // Retrieve player's chosen quantity
    // ------------------------------------------------------------------------------------
    // EXPECTED OUTPUTS:
    //
    // How many are you purchasing today? 1
    // I will calculate the cost of 1 item!     <-- Singular item
    //
    // How many are you purchasing today? 2
    // I will calculate the cost of 2 items!    <-- Plural items
    //
    // How many are you purchasing today? 0
    // Not a valid number of units. I will give you a quantity of 1 instead.

    // How many are you purchasing today? -4
    // Not a valid number of units. I will give you a quantity of 1 instead.
    // ------------------------------------------------------------------------------------

    Console.Write("\nHow many are you purchasing today? ");
    userChosenQuantity = int.Parse(Console.ReadLine()!);

    // TODO: Write a conditional statement to provide the proper output.
    if(userChosenQuantity == 1)
    {
        Console.WriteLine("I will calculate the cost of 1 item!");
    } else if (userChosenQuantity >= 2)
    {
        Console.WriteLine("I will calculate the cost of " + userChosenQuantity + " items!");
    } else
    {
        Console.WriteLine("Not a valid number of units. I will give you a quantity of 1 instead.");
    }


        // ------------------------------------------------------------------------------------
        // Present the total price of purchased items
        // ------------------------------------------------------------------------------------
        // EXPECTED OUTPUTS:
        //
        // Total price: 3 Shield x $40.00 is $120.00
        //
        // Total price: 10 Armor x $100.99 is $1,009.90
        // ------------------------------------------------------------------------------------

        // Calculate the total cost of chosen items
        double totalCost = userChosenQuantity * cost_selected;

    // TODO: Format any costs/prices as currency
    Console.WriteLine($"\nTotal price: " +
        $"{userChosenQuantity} {item_selected} x {cost_selected:C2} is {totalCost:C2}");


    // ------------------------------------------------------------------------------------
    // Thanks. Exit the program.
    // ------------------------------------------------------------------------------------
    Console.WriteLine("Thank you for shopping at the Monster Hunter Shop!");
}