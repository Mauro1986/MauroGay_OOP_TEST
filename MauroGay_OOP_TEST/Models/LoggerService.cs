using System;

namespace MauroGay_OOP_TEST.Models
{
    public static class LoggerService
    {
        public static int size = 0;
        private static LogMessage[] logs = new LogMessage[1];

        static LogMessage[] Logs { get; set; }

        public static void AddLogMessage(LogMessage message)
        {
            size++;
            Array.Resize(ref logs, size);
        }

        static LoggerService()
        {
            logs = new LogMessage[0];
        }
    }
}
