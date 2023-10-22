using System.Collections.Specialized;
using NLog;
using System.IO;

string filePath = "filePath";
TicketManager ticketManager = new TicketManager(filePath);

string path = Directory.GetCurrentDirectory() + "\\nlog.config";
// create instance of Logger
var logger = LogManager.LoadConfiguration(path).GetCurrentClassLogger();
logger.Info("Program started");

// Create an instance of TicketManager and run it
TicketManager _ = new TicketManager(filePath);
ticketManager.Run();

logger.Info("Program ended");









/*// See https://aka.ms/new-console-template for more information
using System.Collections.Specialized;
using NLog;
string path = Directory.GetCurrentDirectory() + "\\nlog.config";
// create instance of Logger
var logger = LogManager.LoadConfiguration(path).GetCurrentClassLogger();
logger.Info("Program started");

while (true)
{
    Console.WriteLine("1) Display tickets");
    Console.WriteLine("2) Enter ticket");
    Console.WriteLine("3) Exit");
    string resp = Console.ReadLine();
  
    if (resp == "1")
    {
        ticketManager.DisplayTickets();
    }
    else if (resp == "2")
    {
        Console.WriteLine("Enter severity");
        string severity = Console.ReadLine();
        Console.WriteLine("Enter software");
        string software = Console.ReadLine();
        Console.WriteLine("Enter reason");
        string reason = Console.ReadLine();
        Console.WriteLine("Enter the estimate");
        string estimate = Console.ReadLine();
        Console.WriteLine("Enter the cost");
        string cost = Console.ReadLine(); Console.WriteLine("Enter project name");
        string projectName = Console.ReadLine();
        Console.WriteLine("Enter due date");
        string dueDate = Console.ReadLine();


        ticketManager.EnterTicket(severity, software, reason, estimate, projectName, dueDate);
    }
    else if (resp == "3")
    {
        break;
    }
}

logger.Info("Program ended");
*/
