using HR.Connect.App.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Connect.App.MVVM.ViewModels
{
    public class AdminPanelPageViewModel
    {
        public AdminPanelModel[] Employees =
        {
            new AdminPanelModel(){
                Name = "aminat",
                Role = "Software Developer",
                PhoneNum = "+1 768 875 7856",
                Email="Aminat@gmail.com",
                Department="Information Technology",
                Location="Toronto Ontario" },

            new AdminPanelModel(){
                Name = "lawal",
                Role = "Tester",
                PhoneNum = "+1 768 833 7856",
                Email="Lawal@gmail.com",
                Department="Information Technology",
                Location="Sudbury Ontario" },

            new AdminPanelModel(){
                Name = "nathan",
                Role = "Senior Developer",
                PhoneNum = "+1 *** 875 7856",
                Email="Nathan@gmail.com",
                Department="Information Technology",
                Location="Toronto Ontario" },

            new AdminPanelModel(){
                Name = "cambrian",
                Role = "CEO",
                PhoneNum = "+1 809 563 ****",
                Email="Cambrian@gmail.com",
                Department="Instituite",
                Location="Sudbury Ontario" },

            new AdminPanelModel(){
                Name = "brent",
                Role = "Professor",
                PhoneNum = "+1 768 875 7856",
                Email="Brent@gmail.com",
                Department="Information Technology",
                Location="NorthBay Ontario" },
        };


    }
}
