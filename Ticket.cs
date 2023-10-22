using NLog;
public abstract class Ticket
{
    // common properties to all tickets
    public int Id { get; set; }
    public string Summary { get; set; }
    public string Status { get; set; }
    public string Priority { get; set; }
    public string Submitter { get; set; }
    public string Assigned { get; set; }
    public string Watching { get; set; }
    public string Severity { get; internal set; }

    // Constructor
    public Ticket(int id, string summary, string status, string priority, string submitter, string assigned, string watching, string severity)
    {
        Id = id;
        Summary = summary;
        Status = status;
        Priority = priority;
        Submitter = submitter;
        Assigned = assigned;
        Watching = watching;
        Severity = severity;
    }

    protected Ticket(int id, string summary, string status, string priority, string submitter, string assigned, string watching)
    {
        Id = id;
        Summary = summary;
        Status = status;
        Priority = priority;
        Submitter = submitter;
        Assigned = assigned;
        Watching = watching;
    }


    // method to be overridden in classes
    public virtual string DisplayTickets()
    {
        return $"Id: {Id}\nSummary: {Summary}\nStatus: {Status}\nPriority: {Priority}\nSubmitter: {Submitter}\nAssigned: {Assigned}\nWatching: {Watching}\nSeverity: {Severity}";
    }
}
