using NLog;

// string filePath = "filePath";
TicketManager ticketManager = new TicketManager();

string path = Directory.GetCurrentDirectory() + "\\nlog.config";
// create instance of Logger
var logger = LogManager.LoadConfiguration(path).GetCurrentClassLogger();
logger.Info("Program started");

// TicketManager _ = new(filePath);
ticketManager.Run();

logger.Info("Program ended");


