using NavigateURLWebApps.DAL.Gatway;
using NavigateURLWebApps.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NavigateURLWebApps.BLL
{
    public class DepartmentManager
    {
        DepartmentGatway DepartmentGatway;
        public DepartmentManager()
        {
            DepartmentGatway = new DepartmentGatway();
        }

        public List<Department>  GetAllStudent()
        {
            return DepartmentGatway.GetAllDepartment();
        }

    }
}