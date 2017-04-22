using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime Birthday { get; set; }
        public string Department { get; set; }

        public Employee(Guid id, string name, string gender, DateTime birthday, string department)
        {
            this.Id = id;
            this.Name = name;
            this.Gender = gender;
            this.Birthday = birthday;
            this.Department = department;
        }
    }
}
