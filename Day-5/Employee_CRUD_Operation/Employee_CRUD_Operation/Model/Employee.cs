using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_CRUD_Operation.Model
{
    public class Employee
    {

        public int empId { get; set; }
        public string empName { get; set; }
        public int empSal { get; set; }

        public string empAddress { get; set; }

        public string empDesignation { get; set; }
    }
}
