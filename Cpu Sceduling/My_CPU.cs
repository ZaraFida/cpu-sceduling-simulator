using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CpuScheduling
{
    class My_CPU
    {
        public Process Inside_Process;
        public bool IsIdle;
        public int priority;
        public int TimeRemaining;


        public My_CPU()
        {
            this.IsIdle = true;
        }
        public void addProcess(Process p)
        {
            Inside_Process = p;
        }





    }
}
