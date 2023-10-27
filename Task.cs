// using Microsoft.VisualBasic;
// using NLog;
// public class Task : Ticket
// {
//     public string Estimate { get; set; }
//     public string ProjectName { get; set; }
//     public DateTime DueDate { get; set; }

//     // Parameterless constructor
//     public Task() : base(0, "", "", "", "", "", "", "")
//     {
//     }
//     // Constructor
//     public Task(int id, string summary, string status, string priority, string submitter, string assigned, string watching, string severity, string projectName, DateTime dueDate)
//     : base(id, summary, status, priority, submitter, assigned, watching, severity)
//     {
//         ProjectName = projectName;
//         DueDate = dueDate;
//     }
//     public virtual void FromCsvLine(string line, DateTime dateOnly)
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
//         ProjectName = fields[8];
//         DueDate = DateTime.Parse(fields[9]);
//     }
// }
