using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Connect.App.MVVM.Models
{
    public class AdminPanelModel
    {
        public int Id { get; set; }
        public string IT { get; set; }
        public string HumanResource { get; set; }
        public string Marketing { get; set; }
        public string Finance { get; set; }
        public string Payroll {  get; set; }

        public AdminPanelModel() { }
    }
}
