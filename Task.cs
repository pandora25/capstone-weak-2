using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capstone_weak2
{
    class Task
    {
        private string names;
        private string briefDescription;
        private DateTime dueDate;
        private bool taskStatus;
       
        //properties
        public string Names
        {
            set; get;
        }
        public string BriefDescription
        {
            set; get;
        }
        public DateTime DueDate
        {
            set; get;
        }
        public bool TaskStatus
        {
            get; set;
        }

        // constuctor defualt
        public Task() {}
        public Task(string names, string briefDescriptions, DateTime DueDates)
        {
            Names = names;
            BriefDescription = briefDescriptions;
            DueDate = DueDates;
            TaskStatus = false;
        }
        public void PrintInfo()
        {
            Console.WriteLine(Names + " " + BriefDescription + " " + DueDate.ToString("MM/dd/yyyy") + " " + TaskStatus);
        }

    }
}