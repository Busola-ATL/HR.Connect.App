using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace HR.Connect.App.MVVM.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Position {  get; set; }
        public Date DateOfEmployment { get; set; }
        public string Email { get; set; }
        public string EmploymentStatus {  get; set; }
        public string Address {  get; set; }

        public Employee() { }

    }
}
