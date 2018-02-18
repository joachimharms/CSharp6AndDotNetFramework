using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C07_004_CustomException2
{
    // This custom exception describes the details of the car-is-dead condition.
    // (Remember, you can also simply extend Exception.)
    public class CarIsDeadException : ApplicationException
    {
        public DateTime ErrorTimeStamp { get; set; }
        public string CauseOfError { get; set; }

        // Diesmal reichen wir die Message an den Basiskonstruktor durch:
        public CarIsDeadException() { }
        public CarIsDeadException(string message,
        string cause, DateTime time) :base(message)
        {
            CauseOfError = cause;
            ErrorTimeStamp = time;
        }

    }
}
