using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Obooking.DesignPatterns.Startegy
{
    public class NotAvailableStatus : StatusBehavioral
    {
        public string status()
        {
            return "Not Available";
        }
    }
}