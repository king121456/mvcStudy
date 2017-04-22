using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class EmployeeRepository
    {
        private static IList<Employee> employeeList;

        static EmployeeRepository()
        {
            employeeList = new List<Employee>();
            employeeList.Add(new Employee(Guid.NewGuid(), "侯晗彬", "男", DateTime.Now, "销售部"));
            employeeList.Add(new Employee(Guid.NewGuid(), "丁琰", "女", DateTime.Now, "护理部"));
            employeeList.Add(new Employee(Guid.NewGuid(), "申伟强", "男", DateTime.Now, "技术部"));
            employeeList.Add(new Employee(Guid.NewGuid(), "拿好", "男", DateTime.Now, "销售部"));
        }

        public IEnumerable<Employee> GetEmployee(Guid id)
        {
            return employeeList.Where(r => r.Id == id);
        }

        public IEnumerable<Employee> GetAll()

        {
            return employeeList;
        }
    }
}
