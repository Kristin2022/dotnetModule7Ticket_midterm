using NLog;
using System;
using System.Collections.Generic;
using System.IO;

public class TicketFile
{
    public string FilePath { get; set; }
    public List<Ticket> Tickets { get; set; }

    public TicketFile(string filePath)
    {
        this.FilePath = filePath;
        this.Tickets = new List<Ticket>();
    }

    public void ReadTickets()
    {
        try
        {
            using (StreamReader sr = new StreamReader(FilePath))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] ticketDetails = line.Split(',');

                      Enhancement ticket = new Enhancement();

                    ticket.Id = (int)UInt64.Parse(ticketDetails[0]);
                    ticket.Summary = ticketDetails[1];
                    ticket.Status = ticketDetails[2];
                    ticket.Priority = ticketDetails[3];
                    ticket.Submitter = ticketDetails[4];
                    ticket.Assigned = ticketDetails[5];
                    ticket.Watching = ticketDetails[6];
                    ticket.Severity = ticketDetails[7];
                    ticket.Software = ticketDetails[8];
                    ticket.Cost = ticketDetails[9];
                    ticket.Reason = ticketDetails[10];
                    ticket.Estimate = ticketDetails[11];
                    ticket.ProjectName = ticketDetails[12];
                    ticket.DueDate = ticketDetails[13];

                    Tickets.Add(ticket);
                }
            }
        }
        catch (Exception ex)
        {
            throw;
        }
    }

    public void WriteTickets()
    {
        using (StreamWriter writer = new StreamWriter(FilePath))
        {
            foreach (var ticket in Tickets)
            {
                string line = $"{ticket.Id},{ticket.Summary},{ticket.Status},{ticket.Priority},{ticket.Submitter},{ticket.Assigned},{ticket.Watching},{ticket.Severity}";

            }
        }
    }
}
/*public void ReadTickets()
{
    try
    {
        using (StreamReader sr = new StreamReader(FilePath))
        {
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] ticketDetails = line.Split(',');

                // Assuming Enhancement is a subclass of Ticket
                Enhancement ticket = new Enhancement();
                // Set properties here...

                Tickets.Add(ticket);
            }
        }
    }
    catch (Exception ex)
    {
        // Handle exception...
    }
}

*/