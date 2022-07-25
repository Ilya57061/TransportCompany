using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany.ViewModels.Employee
{
    public class EmployeesManagersGroup
    {
        public int EmployeeId { get; set; }
        public string EmployeePost { get; set; }
        public int ManagerId { get; set; }
        public string ManagerDepartment{get;set;}

    }
}
