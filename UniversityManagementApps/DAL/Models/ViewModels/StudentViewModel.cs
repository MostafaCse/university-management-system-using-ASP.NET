using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NavigateURLWebApps.DAL.Models.ViewModels
{
    public class StudentViewModel
    {
        public int Id { get; set; }
        public string RegNo { get; set; }
        public string StudentName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string code { get; set; }
        public string DepartmentName { get; set; }
    }
}