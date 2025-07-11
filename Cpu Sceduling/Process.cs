using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace CpuScheduling
{
    class Process
    {
        public String name;
        public int arriveTime;
        public int burstTime;
        public int priority;
        public int waiting_time;
        public int turnaround_time;
        public int start_time;
        public int finish_time;
        public int time_remaining;
        public int countIntime;
        public List<int> putIntimes;
        public bool IsFinish;
        public Process(String name, int arriveTime, int burstTime, int priority)
        {
            this.name = name;
            this.arriveTime = arriveTime;
            this.burstTime = burstTime;
            this.priority = priority;
            this.IsFinish = false;
            this.time_remaining = burstTime;
            this.start_time = -1;
            this.putIntimes = new List<int>();
            this.countIntime = 0;
       }
        public void CalculateWaitingTime()
        {
            waiting_time = start_time - arriveTime;
        }
        public void CalculateTurnAroundTime()
        {
            turnaround_time = waiting_time + burstTime;
        }
        public void setTimeRemaining(int time)
        {
            this.time_remaining = time;
        }
        public void decrementTimeRemaining(int de)
        {
            time_remaining = time_remaining - de;
        }
        public int getTimeWhenShouldFinish()
        {
            return start_time + burstTime;
        }
        public int getName()
        {
            int count = name.Length;
            return Convert.ToInt32(name.Substring(1, count - 1));
        }
    }
}
