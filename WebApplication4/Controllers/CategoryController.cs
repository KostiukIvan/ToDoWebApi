using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    
    public class CategoryController : ApiController
    {
        public MyModel _category = new MyModel();

        public CategoryController()
        {
           List<Task> tasks = new List<Task>();
            _category.Name = "TODO";
            _category.addTask("Kupic_wode", "11.12.21");
            _category.addTask("Kupic_samochod", "11.12.21");
            _category.addTask("Kupic_rower", "11.12.21");

        }

        // GET: api/Category
        public MyModel Get()
        {
            return _category;
        }

        // GET: api/Category/5
        public Task Get(string name)
        {
            foreach(var x in _category.Tasks)
            {
                if( x.Name == name)
                {
                    return x;
                }
            }
            return new Task { Name = "ERROR", Date = "ERROR" };
        }

        // POST: api/Category
        public void Post(Task task)
        {
            //Check if this categoty alregy exist
            foreach(var  x in _category.Tasks)
            {
                if(x.Name == task.Name)
                {
                    //It exist already
                    return;
                }
            }
            _category.Tasks.Add(task);

        }

        // PUT: api/Category/5
        public void Put(string name, Task nowy)
        {
            Task tmp = _category.getTask(name);
            tmp.Name = nowy.Name;
            tmp.Date = nowy.Date;
        }

        // DELETE: api/Category/5
        public void Delete(string name)
        {
            foreach(var x in _category.Tasks)
            {
                if(x.Name == name)
                {
                    _category.Tasks.Remove(x);
                }
            }
        }
    }
}
