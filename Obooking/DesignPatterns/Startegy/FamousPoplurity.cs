using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Obooking.DesignPatterns.Startegy
{
    public class FamousPoplurity : PopularitBehavioral
    {
        public string popluarity()
        {
            return "Famous";
        }
    }
}