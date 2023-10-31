using NLog;
public class TicketManager
{
    public TicketFile<DefectBug> DefectBugFile { get; set; }
    public TicketFile<Enhancement> EnhancementFile { get; set; }
    public TicketFile<Task> TaskFile { get; set; }
    public TicketManager()
    {
        DefectBugFile = new TicketFile<DefectBug>("DefectBug.csv");
        EnhancementFile = new TicketFile<Enhancement>("Enhancement.csv");
        TaskFile = new TicketFile<Task>("Task.csv");
    }

    public void Run()
    {
        while (true)
        {
            Console.WriteLine("1) Display tickets");
            Console.WriteLine("2) Enter defect bug ticket");
            Console.WriteLine("3) Enter enhancement ticket");
            Console.WriteLine("4) Enter task ticket");
            Console.WriteLine("5) Exit");
            string resp = Console.ReadLine();


            if (resp == "1")
            {
                DisplayTickets();


            }
            //DefectBug
            else if (resp == "2")
            {
                DefectBug defectBug = EnterDefectBugTicket();
                DefectBugFile.Tickets.Add(defectBug);
                DefectBugFile.WriteTicket(defectBug);
            }
            //Enhancement
            else if (resp == "3")
            {
                Enhancement enhancement = EnterEnhancementTicket();
                EnhancementFile.Tickets.Add(enhancement);
                EnhancementFile.WriteTicket(enhancement);
            }
            //Task
            else if (resp == "4")
            {
                Task task = EnterTaskTicket();
                TaskFile.Tickets.Add(task);
                TaskFile.WriteTicket(task);
            }
            //Exit
            else if (resp == "5")
            {
                break;
            }
        }
    }
    public void DisplayTickets()
    {
        System.Console.WriteLine("DefectBug tickets: ");
        foreach (var t in DefectBugFile.Tickets)
        {
            t.Display();
        }
        System.Console.WriteLine("Enhancement tickets: ");
        foreach (var t in EnhancementFile.Tickets)
        {
            t.Display();
        }
        System.Console.WriteLine("Task tickets: ");
        foreach (var t in TaskFile.Tickets)
        {
            t.Display();
        }
    }

    public DefectBug EnterDefectBugTicket()
    {
        DefectBug defectBug = new DefectBug();
        Console.WriteLine("Enter ticket id");
        defectBug.Id = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter summary");
        defectBug.Summary = Console.ReadLine();
        Console.WriteLine("Enter status");
        defectBug.Status = Console.ReadLine();
        Console.WriteLine("Enter priority");
        defectBug.Priority = Console.ReadLine();
        Console.WriteLine("Enter submitter");
        defectBug.Submitter = Console.ReadLine();
        Console.WriteLine("Enter assigned");
        defectBug.Assigned = Console.ReadLine();
        Console.WriteLine("Enter watching");
        defectBug.Watching = Console.ReadLine();
        Console.WriteLine("Enter severity");
        defectBug.Severity = Console.ReadLine();

        return defectBug;
    }

    public Enhancement EnterEnhancementTicket()
    {
        Enhancement enhancement = new Enhancement();
        Console.WriteLine("Enter ticket id");
        enhancement.Id = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter summary");
        enhancement.Summary = Console.ReadLine();
        Console.WriteLine("Enter status");
        enhancement.Status = Console.ReadLine();
        Console.WriteLine("Enter priority");
        enhancement.Priority = Console.ReadLine();
        Console.WriteLine("Enter submitter");
        enhancement.Submitter = Console.ReadLine();
        Console.WriteLine("Enter assigned");
        enhancement.Assigned = Console.ReadLine();
        Console.WriteLine("Enter watching");
        enhancement.Watching = Console.ReadLine();
        Console.WriteLine("Enter severity");
        enhancement.Severity = Console.ReadLine();
        Console.WriteLine("Enter software");
        enhancement.Software = Console.ReadLine();
        Console.WriteLine("Enter cost");
        enhancement.Cost = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter reason");
        enhancement.Reason = Console.ReadLine();
        Console.WriteLine("Enter estimate");
        enhancement.Estimate = double.Parse(Console.ReadLine());

        return enhancement;
    }

    public Task EnterTaskTicket()
    {
        Task task = new ();
        Console.WriteLine("Enter ticket id");
        task.Id = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter summary");
        task.Summary = Console.ReadLine();
        Console.WriteLine("Enter status");
        task.Status = Console.ReadLine();
        Console.WriteLine("Enter priority");
        task.Priority = Console.ReadLine();
        Console.WriteLine("Enter submitter");
        task.Submitter = Console.ReadLine();
        Console.WriteLine("Enter assigned");
        task.Assigned = Console.ReadLine();
        Console.WriteLine("Enter watching");
        task.Watching = Console.ReadLine();
        Console.WriteLine("Project name");
        task.ProjectName = Console.ReadLine();
        Console.WriteLine("Due date");
        task.DueDate = DateTime.Parse(Console.ReadLine());

        return task;
    }

}












































