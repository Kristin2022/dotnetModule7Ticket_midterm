public class Enhancement : Ticket
{
    // Additional properties for Enhancement
    public string Severity { get; set; }
    public string Software { get; set; }
    public double Cost { get; set; }
    public string Reason { get; set; }
    public double Estimate { get; set; }

    // Constructor
    public Enhancement(int id, string summary, string status, string priority, string submitter, string assigned, string watching,
                       string severity, string software, double cost, string reason, double estimate)
        : base(id, summary, status, priority, submitter, assigned, watching)
    {
        Severity = severity;
        Software = software;
        Cost = cost;
        Reason = reason;
        Estimate = estimate;
    }

    // Override Display method
    public override string DisplayTickets()
    {
        return base.DisplayTickets() + $"\nSeverity: {Severity}\nSoftware: {Software}\nCost: {Cost}\nReason: {Reason}\nEstimate: {Estimate}";
    }
}
