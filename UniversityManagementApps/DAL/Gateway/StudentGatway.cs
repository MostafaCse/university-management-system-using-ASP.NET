using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NavigateURLWebApps.DAL.Models;
using System.Data.SqlClient;
using System.Web.Configuration;
using NavigateURLWebApps.DAL.Models.ViewModels;

namespace NavigateURLWebApps.DAL.Gatway
{
    public class StudentGatway : ComonGatway
    {
        public int Save(Student student1)
        {
            //  SqlConnection connection = new SqlConnection(connectionString);

            // SqlConnection connection=new SqlConnection("Data Source=DESKTOP-7OCQ69G;Initial Catalog=UniversityDB1;Integrated Security=True") dircet method

            string query = "INSERT INTO Student VALUES('" +student1.RegNo+ "','"+student1.Name+"','" + student1.Email + "','" + student1.Phone + "','" + student1.Address + "','" + student1.DepartmentId + "')";

            Command = new SqlCommand(query, Connection);

            Connection.Open();
            int rowaffect = Command.ExecuteNonQuery();
            Connection.Close();
            return rowaffect;
        }

        public List<StudentViewModel> GetAllStudent()
        {
            string query = "SELECT s.id,s.RegNo,s.Name as StudentName,s.Email,s.Phone,s.Address,d.Code,d.Name as DepartmentName from Student as s inner join department as d on s.DepartmentId=d.Id";
             Command = new SqlCommand(query, Connection);
            Connection.Open();
         Reader = Command.ExecuteReader();

         //   List<Student> Students = new List<Student>();
         List<StudentViewModel> StudentViewModels = new List<StudentViewModel>();

            while (Reader.Read())
            {
               // Student student = new Student();
               // student.Id = Convert.ToInt32(Reader["Id"]);
               // student.Name = Reader["Name"].ToString();
               // student.RegNo = Reader["RegNo"].ToString();
               // student.Email = Reader["Email"].ToString();
               // student.Phone = Reader["Phone"].ToString();
               // student.Address = Reader["Address"].ToString();
               //student.DepartmentId = Reader["Department"].ToString();
               // Students.Add(student);
                StudentViewModel StudentViewModel = new StudentViewModel();
                StudentViewModel.Id =Convert.ToInt32( Reader["Id"]);
                StudentViewModel.StudentName = Reader["StudentName"].ToString();
                StudentViewModel.RegNo = Reader["RegNo"].ToString();
                StudentViewModel.Email = Reader["Email"].ToString();
                StudentViewModel.Phone = Reader["Phone"].ToString();
                StudentViewModel.Address = Reader["Address"].ToString();
                StudentViewModel.code = Reader["Code"].ToString();
                StudentViewModel.DepartmentName = Reader["DepartmentName"].ToString();
                StudentViewModels.Add(StudentViewModel);

            }
            Reader.Close();
            Connection.Close();
          //  return Students;

            return StudentViewModels;

        }

        public bool IsRegExists(string regNo)
        {
            string query = "SELECT * FROM Student WHERE RegNo='" + regNo + "'";
            Command = new SqlCommand(query, Connection);
            Connection.Open();

          Reader = Command.ExecuteReader();
    bool IsExits=Reader.HasRows;
          Reader.Close();
          Connection.Close();
          return IsExits;       
        }

        public Student GetStudentById(int id)
        {
            string query = "SELECT * FROM Student WHERE Id=" + id;
            Command = new SqlCommand(query,Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            Student student1 = new Student();
           if(Reader.HasRows)
           {
               Reader.Read();
               student1.Id = Convert.ToInt32(Reader["id"]);
               student1.RegNo = Reader["RegNo"].ToString();
               student1.Name = Reader["Name"].ToString();
               student1.Email = Reader["Email"].ToString();
               student1.Phone = Reader["Phone"].ToString();
               student1.Address = Reader["Address"].ToString();
               student1.DepartmentId =Convert.ToInt32(Reader["DepartmentId"]);
               Reader.Close();
           }
            Connection.Close();
            return student1;
        }

       public int UpdateByStudentId(Student student1)
        {
            string query = "UPDATE Student SET RegNo='" + student1.RegNo + "',Name='" + student1.Name + "',Email='" + student1.Email + "',Phone='" + student1.Phone + "',Address='" + student1.Address + "',Department='" + student1.DepartmentId + "' WHERE Id="+ student1.Id;

            Command = new SqlCommand(query, Connection);

            Connection.Open();
            int rowaffect = Command.ExecuteNonQuery();
            Connection.Close();
            return rowaffect;
        }
        public int Delete(int id)
       {
           string query = "DELETE FROM Student WHERE Id=" + id;
           Command = new SqlCommand(query, Connection);

           Connection.Open();
           int rowaffect = Command.ExecuteNonQuery();
           Connection.Close();
           return rowaffect;
       }
    }
}