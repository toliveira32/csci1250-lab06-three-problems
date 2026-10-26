/*
* Name: Tiago Miguel Lourenço Vedes de Oliveira
* Course: CSCI 1250, Section 001
* Assignment: Lab 06, Three Short Problems
* Date: October 21, 2026
* Description: A menu that keeps running until the user quits, offering three
* independent exercises or all three at once. Each exercise
* practices decisions and one of the four loops.
*/

//menu layout information for the user to see
Console.WriteLine("=== CSCI 1250 Lab 06 ===");
Console.WriteLine("1. The Grade Checker");
Console.WriteLine("2. The Dice Table");
Console.WriteLine("3. The Score Report");
Console.WriteLine("4. All three");
Console.WriteLine("5. Quit");

//variable choice that stacks the value the user inserts at the menu
int choice = 0;

/*do
{
// print the five lines
// validate the choice
// the three if statements
} while (choice != 5);
Console.WriteLine("Goodbye.");
*/

//i choose the while loop because i think it was the only one we could use for this situation, the for loop woudlnt work since i dont know for how long i want to run the loop, so i used the while, since we are waiting for the user right input, works just as english "while the user is not typing this numbers make him do something"
while (choice < 1 || choice > 5)
{
    Console.Write("choose 1 through 5: ");
    choice = Convert.ToInt32(Console.ReadLine());
}

if (choice == 1 || choice == 4)
{
    // === Exercise 1: The Grade Checker ===
    Console.WriteLine("=== Exercise 1: The Grade Checker ===");

    int score = 2003;

    // this one i would say its pretty much like the other while loop, we dont know how many tries the user is gonna need to get it right so the for loop wouldnt work, its the same logic as the menu one basically
    while (score < 0 || score > 100)
    {
        Console.Write("Score: ");
        score = Convert.ToInt32(Console.ReadLine());

        if (score < 0 || score > 100)
        {
            Console.WriteLine("A score must be between 0 and 100.");
        }
    }

    if (score >= 90)
    {
        Console.WriteLine(score + " earns an A.");
    }
    else if (score >= 80)
    {
        Console.WriteLine(score + " earns a B.");
    }
    else if (score >= 70)
    {
        Console.WriteLine(score + " earns a C.");
    }
    else if (score >= 60)
    {
        Console.WriteLine(score + " earns a D.");
    }
    else
    {
        Console.WriteLine(score + " earns an F.");
    }
}

if (choice == 2 || choice == 4)
{
    // Exercise 2
    Console.WriteLine("(dice table)");
}

if (choice == 3 || choice == 4)
{
    // Exercise 3
    Console.WriteLine("(score report)");
}

