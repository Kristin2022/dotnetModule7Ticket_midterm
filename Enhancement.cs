// using NLog;
// public class Enhancement : Ticket
// {
//     //properties to go with abstract Ticket class
//     public string Software { get; set; }
//     public double Cost { get; set; }
//     public string Reason { get; set; }
//     public double Estimate { get; set; }

//     //Parameterless constructor
//     // public Enhancement(string id) : base(0, "", "", "", "", "", "", "")
//     // {
//     // }
//     // Constructor
//     public Enhancement(int id, string summary, string status, string priority, string submitter, string assigned, string watching, string severity, string software, double cost, string reason, double estimate)
//         : base(id, summary, status, priority, submitter, assigned, watching, severity)
//     {
//         Software = software;
//         Cost = cost;
//         Reason = reason;
//         Estimate = estimate;
//     }
//     public override void FromCsvLine(string line)
//     {
//         var fields = line.Split(',');
//         Id = int.Parse(fields[0]);
//         Summary = fields[1];
//         Status = fields[2];
//         Priority = fields[3];
//         Submitter = fields[4];
//         Assigned = fields[5];
//         Watching = fields[6];
//         Severity = fields[7];
//         Software = fields[8];
//         Cost = double.Parse(fields[9]);
//         Reason = fields[10];
//         Estimate = double.Parse(fields[11]);
//     }
// }


