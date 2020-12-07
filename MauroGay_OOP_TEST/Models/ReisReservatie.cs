using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauroGay_OOP_TEST.Models;

namespace MauroGay_OOP_TEST.Models
{
    class ReisReservatie /*: ILoggable*/
    {
        public LogMessage LogMessage { get; set; }
        public Persoon Persoon { get; set; }           
        public Reis Reis { get; set; }                  
        public Reisbureau Reisbureau { get; set; }

        public ReisReservatie(LogMessage logmessage, Persoon persoon, Reis reis, Reisbureau reisbureau)
        {
            LogMessage = logmessage;
            Persoon = persoon;
            Reis = reis;
            Reisbureau = reisbureau;
        }

        //methode AddLogMessage van LoggerService moet hier nog worden opgeroepen...
        //public static void AddLogMessage(LogMessage message)
        //{
        //    size++;
        //    Array.Resize(ref logs, size);
        //}

        public ReisReservatie()  
        {
            LoggerService.AddLogMessage(LogMessage);
        }
    }
}