using Microsoft.VisualBasic;
using NLog;
using System;
using System.Collections.Generic;

public class TicketManager
{
    public List<Ticket> Tickets { get; set; }

    public TicketManager(string filePath)
    {
        Tickets = new List<Ticket>();
        Enhancement enhancement = new ();
        Task task = new Task();
    }
    public void Run()
    {
        while (true)
        {
            Console.WriteLine("1) Display tickets");
            Console.WriteLine("2) Enter ticket");
            Console.WriteLine("3) Exit");
            string resp = Console.ReadLine();

            if (resp == "1")
            {
                DisplayTickets();
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
                double estimate = Console.ReadLine();
                Console.WriteLine("Enter the cost");
                double cost = Console.ReadLine(); 
                Console.WriteLine("Enter project name");
                string projectName = Console.ReadLine();
                Console.WriteLine("Enter due date");
                string dueDate = Console.ReadLine();
                EnterTicket(severity, software, reason, estimate, projectName, dueDate, GetEstimate());
            }
            else if (resp == "3")
            {
                break;
            }
        }
    }

    private void EnterTicket(string severity, string software, string reason, double estimate, string projectName, string dueDate, Task task)
    {
        throw new NotImplementedException();
    }

    private Task GetEstimate()
    {
        throw new NotImplementedException();
    }

    public void DisplayTickets()
    {
        foreach (var ticket in Tickets)
        {
            Console.WriteLine(ticket.ToString());
        }
    }
public void EnterTicket(string severity, string software, string reason, double estimate, string projectName, string dueDate)
{
    Console.WriteLine("Enter the estimate");
    string estimateInput = Console.ReadLine();
        if (!double.TryParse(estimateInput,
                             out double estimateInput))
        {
            Console.WriteLine("Invalid input. Please enter a number for the estimate.");
            return;
        }

        Console.WriteLine("Enter the cost");
    string costInput = Console.ReadLine();
    double cost;
    if (!double.TryParse(costInput, out cost))
    {
        Console.WriteLine("Invalid input. Please enter a number for the cost.");
        return;
    }

    Enhancement newEnhancement = new Enhancement 
    {
        Severity = severity,
        Software = software,
        Reason = reason,
        Estimate = estimate,
        Cost = cost,
        ProjectName = projectName,
        DueDate = dueDate
    };
    Tickets.Add(newEnhancement);

    Task newTask = new Task
    {
        ProjectName = projectName,
        DueDate = dueDate
    };
    Tickets.Add(newTask);
}
}
