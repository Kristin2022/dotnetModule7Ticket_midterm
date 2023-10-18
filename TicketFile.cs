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

                    Ticket ticket = new Ticket();
                    ticket.Id = UInt64.Parse(ticketDetails[0]);
                    ticket.Summary = string.Parse(ticketDetails[1]);
                    ticket.Status = string.Parse(ticketDetails[2]);
                    ticket.Priority = string.Parse(ticketDetails[3]);
                    ticket.Summary = string.Parse(ticketDetails[4]);
                    ticket.Status = string.Parse(ticketDetails[5]);
                    ticket.Priority = string.Parse(ticketDetails[6]);
                    ticket.Summary = string.Parse(ticketDetails[7]);
                    ticket.Status = string.Parse(ticketDetails[8]);
                    ticket.Priority = string.Parse(ticketDetails[]9);
                    ticket.Summary = string.Parse(ticketDetails[10]);
                    ticket.Status = string.Parse(ticketDetails[11]);
                    ticket.Priority = string.Parse(ticketDetails[12]);
                    
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
            string line = $"{ticket.Id},{ticket.Summary},{ticket.Status},{ticket.Priority},{Submitter},{Assigned},{Watching},{Severity},{Software},{Cost},{Reason},{Estimate},{ProjectName}, {DueDater}"; 
            writer.WriteLine(line);
        }
    }
}
