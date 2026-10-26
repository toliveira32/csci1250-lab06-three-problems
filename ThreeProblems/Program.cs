/*
* Name: Tiago Miguel Lourenço Vedes de Oliveira
* Course: CSCI 1250, Section 001
* Assignment: Lab 06, Three Short Problems
* Date: October 21, 2026
* Description: A menu that keeps running until the user quits, offering three
* independent exercises or all three at once. Each exercise
* practices decisions and one of the four loops.
*/

// random number we are using to have a seed for the dice roll 
Random rng = new Random(4000);

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
    // Exercise 1
    Console.WriteLine("=== Exercise 1: The Grade Checker ===");
    // variable score that stores the score the user will input, same as the choice one on the menu
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
    Console.WriteLine("=== Exercise 2: The Dice Table ===");
    
    //variables we used to stored how many rolls the user has done and how many times he has won, we need to know as well if the user wants to keep on rolling and i choose to do it while stacking it on a variable string stacking his yes or no answer inside to give to our do while loop
    int rolls = 0;
    int wins = 0;
    string again = "";

    // in this case like the professor said on the example, we need to always roll the dices anyway, even if the user doesnt want to keep on rolling more, we are always forced to roll at least once, so "we need to DO something(rolling the dice) WHILE the user answer is still yes" 
    do
    {
        int die1 = rng.Next(1, 7);
        int die2 = rng.Next(1, 7);
        int total = die1 + die2;
        rolls++;

        Console.Write($"Roll {rolls}: {die1} and {die2}, total {total}.");

        if (die1 == 1 && die2 == 1)
        {
            Console.WriteLine(" Snake eyes.");
        }
        else if (die1 == die2)
        {
            Console.WriteLine(" Doubles!");
        }
        else if (total == 7 || total == 11)
        {
            Console.WriteLine(" A winner.");
            wins++;
        }
        else
        {
            Console.WriteLine();
        }

        Console.Write("Roll again? (y/n): ");
        again = Console.ReadLine();
    } 
    while (again == "y");

    Console.WriteLine($"You rolled {rolls} times and won {wins}.");
}

if (choice == 3 || choice == 4)
{
    // Exercise 3
    Console.WriteLine("=== Exercise 3: The Score Report ===");

    int[] scores = new int[5];
}

