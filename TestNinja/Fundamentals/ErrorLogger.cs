using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Fundamentals
{
    public class ErrorLogger
    {
        public string LastError { get; set; }

        public void Log(string error)
        {
           if (string.IsNullOrWhiteSpace(error))
            throw new ArgumentNullException();
           LastError = error;
        }
    }
}
