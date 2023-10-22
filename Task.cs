public class Task : Ticket
{
    internal string Estimate;

    public string ProjectName { get; set; }
    public DateTime DueDate { get; set; }

    // Constructor
    public Task(int id, string summary, string status, string priority, string submitter, string assigned, string watching,
                string projectName, DateTime dueDate)
        : base(id, summary, status, priority, submitter, assigned, watching)
    {
        ProjectName = projectName;
        DueDate = dueDate;
    }    

    // Override 
    public override string DisplayTickets()
    {
        return base.DisplayTickets() +
               $"\nProjectName: {ProjectName}\nDueDate: {DueDate}";
    }
}
