﻿// We are creating an app to sell tickets
/*
 * Start off by asking what someone wants to buy tickets for
 * Capture their responce
 * are tickets available (return true)
 * give confirmatiom on ticket, repeat back what they bought
 * ask them to comfirm (y/n)
 * Success Message
 * */

Console.WriteLine("What would you like to purchase?");
string ticketName = Console.ReadLine();
Console.WriteLine("You typed in: " + ticketName);
Console.WriteLine("Is this correct?");
string confirmTickets = Console.ReadLine();

List<string> yesReponces = new List<string>() { "Yes", "Y", "yes", "y" };
List<string> noResponces = new List<string>() { "No", "N", "no", "n"};

if (yesReponces.Contains(confirmTickets))
{
    Console.WriteLine("Fantastic! Your Purchase has been confirmed! You are all set!");
} 
else if (noResponces.Contains(confirmTickets))
{
    Console.WriteLine("Lets try again");
}
else
{
    Console.WriteLine("You have made and incorrect selection");
}