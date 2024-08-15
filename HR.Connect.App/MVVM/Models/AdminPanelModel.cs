using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Connect.App.MVVM.Models
{
    public class AdminPanelModel
    {
        //This will be a static data for that will be binded with the controls  on admin page, it will be seeded with some data in adminPageModelView. Due to the timeframe, I will later in future replace this with an API.
       public string? Role {  get; set; }
        public string? Name { get; set; }
        public string? PhoneNum {  get; set; }
        public string? Email {  get; set; }
        public string? Department { get; set; }
        public string? Location {  get; set; }

        public AdminPanelModel()
        {

        }

    }
}
