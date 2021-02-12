using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Connection
{
    public class EmployeeFacade
    {
        public List<Employees> GetAllEmployees()
        {

            NORTHWNDEntities DataContext = new NORTHWNDEntities();
            var employees = DataContext.Employees.ToList();

            return employees;
        }
    }
}
