﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Obooking.DesignPatterns.Startegy
{
    public class CommonPoplurity : PopularitBehavioral
    {
        public string popluarity()
        {
            return "Common";
        }
    }
}