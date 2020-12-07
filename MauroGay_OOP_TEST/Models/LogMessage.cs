using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauroGay_OOP_TEST.Models
{
    public class LogMessage
    {

        public string Boodschap { get; set; }
        public int ID { get; set; }

        public int GenereerID()
        { 
         return ID = ID + 1;       
        }

        public LogMessage(string boodschap)
        {
            Boodschap = boodschap;
            ID = GenereerID();
        }
    }
}