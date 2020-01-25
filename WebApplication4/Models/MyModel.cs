using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class Task
    {
        public String Name { get; set; } = "";
        public String Date { get; set; } = "";
    }

    public class MyModel
    {
        public List<Task> Tasks { get; set; } = new List<Task>();
        public String Name { get; set; } = "";
        public MyModel()
        {
        }

        public void addTask(String name, String date)
        {
            Tasks.Add(new Task() { Name = name, Date = date });
        }
        public Task getTask(String name)
        {
            Task res;
            foreach(var x in Tasks)
            {
                if(x.Name == name)
                {
                    return x;
                }
            }
            return new Task { Name = "ERROR", Date = "ERROR" };

        }

    }
}