/*
//  Author: Jonathan Scholl
//  Date: 3/27/2022
//  Project: SimpleATM - https://www.youtube.com/watch?v=qBI7Qnz9Zho
//  
*/
using ATM;


void printOptions()
{
    Console.WriteLine("Please choose an option:");
    Console.WriteLine("*******************");
    Console.WriteLine("1: Deposit");
    Console.WriteLine("2: Withdraw");
    Console.WriteLine("3: Show Balance");
    Console.WriteLine("4: Exit");
    Console.WriteLine("*******************");
}

void deposit(cardHolder currentUser)
    {
        Console.WriteLine("How much money would you like to deposit?: ");
        double deposit = Double.Parse(Console.ReadLine());
        currentUser.setBalance(currentUser.getBalance() + deposit);
        Console.WriteLine($"Thank you for your money. You new balance is: {currentUser.getBalance()}");
    }

    void withdraw(cardHolder currentUser)
    {
        Console.WriteLine("How much money would you like to withdraw?: ");
        double withdrawal = Double.Parse(Console.ReadLine());
        if (currentUser.getBalance() < withdrawal)
        {
            Console.WriteLine("Insufficient balance");
        }
        else
        {
            currentUser.setBalance(currentUser.getBalance() - withdrawal);
            Console.WriteLine("Thank you for your withdrawal");
        }
    }
    void balance(cardHolder currentUser)
    {
        Console.WriteLine($"Current balance: {currentUser.getBalance()}");
    }

    List<cardHolder> cardHolders = new List<cardHolder>();
    cardHolders.Add(new cardHolder("12341324113", 1234, "Jon", "Scholl", 987.45));
    cardHolders.Add(new cardHolder("12341324114", 7233, "Scam", "Newton", 20.00));
    cardHolders.Add(new cardHolder("12341324115", 2343, "Austin", "Riley", 2342234.34));
    cardHolders.Add(new cardHolder("12341324116", 4321, "Matt", "Olson", 52.32));
    cardHolders.Add(new cardHolder("12341324117", 6969, "Tyler", "Matzek", 300.00));


    //prompt user
    Console.WriteLine("Welcome to ATM");
    Console.WriteLine("Insert your debit card");
    String debitCardNum = "";
    cardHolder currentUser;

    while (true)
    {
        try
        {
            debitCardNum = Console.ReadLine();
            //check against db
            currentUser = cardHolders.FirstOrDefault(a => a.cardNum == debitCardNum);
            if (currentUser != null) { break; }
            else { Console.WriteLine("Card not recognized. Please try again"); }
        }
        catch{Console.WriteLine("Card not recognized. Please try again");}
    }

    Console.WriteLine("Please enter your pin: ");
    int userPin = 0;
    while (true)
    {
        try
        {
            userPin = int.Parse(Console.ReadLine());
            //check against db
            if (currentUser.getPin() == userPin) { break; }
            else { Console.WriteLine("Incorrect pin. Please try again"); }
        }
        catch { Console.WriteLine("Incorrect pin. Please try again"); }
    }

    Console.WriteLine($"Welcome + {currentUser.getFirstName()}");
    int option = 0;
    do
    {
        printOptions();
        try
        {
            option = int.Parse(Console.ReadLine());
        }
        catch { }
        if (option == 1) 
        { 
            deposit(currentUser); 
        }
        else if (option == 2) 
        { 
            withdraw(currentUser); 
        }
        else if (option == 3) 
        { 
            balance(currentUser); 
        }
        else if (option == 4) 
        { 
            break; 
        }
        else 
        { 
            option = 0; 
        } 

    }
    while (option != 4);
    {
        Console.WriteLine("Have a nice day!");
    }
