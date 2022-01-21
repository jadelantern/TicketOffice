// We are creating an app to sell tickets
/*
 * Start off by asking what someone wants to buy tickets for
 * Capture their responce
 * are tickets available (return true)
 * give confirmatiom on ticket, repeat back what they bought
 * ask them to comfirm (y/n)
 * Success Message
 * 
 * 01/13/2022
 * Have to come up with a way to keep record of transactions
 * 
 * */

using System.Runtime.CompilerServices;

List<Transaction> transactions = new List<Transaction>();
List<CustomerInfo> allCustomerInfo = new List<CustomerInfo>();

List<string> yesReponces = new List<string>() { "Yes", "Y", "yes", "y"};
List<string> noResponces = new List<string>() { "No", "N", "no", "n"};

Console.WriteLine("Welcome to the Ticket Office!");
string ticketName = GetTicketName();
bool confirmed = ConfrimTicket(ticketName);
if (confirmed == true)
{
    Console.WriteLine("Your ticket has been purchased");
}
else 
{ 
    Console.WriteLine("You have not purchased a ticket"); 
}




string GetTicketName()
{
    Console.WriteLine("What would you like to purchase?");
    string ticketName = Console.ReadLine();
    return ticketName;
}


bool ConfrimTicket(string ticketName)
{
    Console.WriteLine("You typed in: " + ticketName);
    Console.WriteLine("Is this correct?");
    string confirmTickets = Console.ReadLine();

    if (yesReponces.Contains(confirmTickets))
    {
        Console.WriteLine("Your Purchase has been confirmed!");
        return true;
    }
    else if (noResponces.Contains(confirmTickets))
    {
        Console.WriteLine("Your responce was 'No'. No ticket was confirmed");
        return false;
    }
    else
    {
        Console.WriteLine("You did not enter a 'Yes' or 'No' responce");
        return false;
    }
}


Transaction CreateTransaction(string ticketName)
{
    Transaction transaction = new Transaction();
    transaction.ticketName = ticketName;
    transactions.Add(transaction);
    transaction.price = 10;

    Console.WriteLine("Please enter your name: ");
    transaction.customer = new CustomerInfo();
    transaction.customer.name = Console.ReadLine();
    allCustomerInfo.Add(transaction.customer);
    return transaction;
}