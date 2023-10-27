using NLog;
public class DefectBug : Ticket
{
    // Parameterless constructor
    // public DefectBug() : base(0, "", "", "", "", "", "", "")
    // {
    // }   
//constructor
    // public DefectBug(int id, string summary, string status, string priority, string submitter, string assigned, string watching, string severity)
    //     : base(id, summary, status, priority, submitter, assigned, watching, severity)
    // {
            
    // }

    
         public override void FromCsvLine(string line)
    {
        var fields = line.Split(',');
        Id = int.Parse(fields[0]);
        Summary = fields[1];
        Status = fields[2];
        Priority = fields[3];
        Submitter = fields[4];
        Assigned = fields[5];
        Watching = fields[6];
        Severity = fields[7];
    }
}

