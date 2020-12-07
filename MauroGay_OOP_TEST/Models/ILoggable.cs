using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauroGay_OOP_TEST.Models;

namespace MauroGay_OOP_TEST.Models
{
    public interface ILoggable
    {
        LogMessage LogMessage { get; set; }
    }
}