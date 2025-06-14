using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Obooking.DesignPatterns.Startegy
{
    public class Bookkk
    {
        StatusBehavioral status;
        PopularitBehavioral Popularit;

        public string performstatusAvaliable()
        {
            status = new AvailableStatus();
            return status.status();
        }
        public string performstatusUnAvaliable()
        {
            status = new NotAvailableStatus();
            return status.status();
        }
        public string performstatusAboutToEnd()
        {
            status = new AboutToEndStatus();
            return status.status();
        }
        public string performspoplrityFamous()
        {
            Popularit = new FamousPoplurity();
            return Popularit.popluarity();
        }
        public string performspoplrityCommon()
        {
            Popularit = new CommonPoplurity();
            return Popularit.popluarity();
        }
        public string performspoplrityUnkown()
        {
            Popularit  = new UnkownPoplurity();
            return Popularit.popluarity();
        }
    }
}