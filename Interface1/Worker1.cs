using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1
{
    public class Worker1 : IWorker
    {
        Ilogger Logger { get; set; }    
        public Worker1(Ilogger Logger)
        { this.Logger = Logger; }

        public void Work()
        {
            Logger.Event("Worker 1 Started");
            Thread.Sleep(1000);
            Logger.Event("Worker 1 Stoped");
        }
    }
}
