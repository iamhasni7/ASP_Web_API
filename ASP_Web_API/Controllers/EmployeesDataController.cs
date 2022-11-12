using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ASP_Web_API.Controllers
{
    public class EmployeesDataController : ApiController
    {
        public string[] myEmployees = { "Ali", "Usman", "Hamza" };

        [HttpGet]
        public string[] GetEmployees()
        {
            return myEmployees;
        }

        [HttpGet]
        public string GetEmployeeByIndex(int id)
        {
            return myEmployees[id];
        }
    }
}
