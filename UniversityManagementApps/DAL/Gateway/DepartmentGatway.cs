using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NavigateURLWebApps.DAL.Models;
using System.Data.SqlClient;
using System.Web.Configuration;


namespace NavigateURLWebApps.DAL.Gatway
{
    public class DepartmentGatway : ComonGatway
    {
       
       public List<Department> GetAllDepartment()
       {
           string Query="SELECT * FROM Department";

           Command = new SqlCommand(Query, Connection);
           Connection.Open();
           Reader = Command.ExecuteReader();
           List<Department> Departments = new List<Department>();
           while(Reader.Read())
           {
               Department Department = new Department();
               Department.Id = Convert.ToInt32(Reader["Id"]);
               Department.code = Reader["Code"].ToString();
               Department.Name = Reader["Name"].ToString();

               Departments.Add(Department);
           }

           Connection.Close();
           return Departments;

       }

    }
}