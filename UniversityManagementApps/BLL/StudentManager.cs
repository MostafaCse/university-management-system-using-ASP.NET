using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NavigateURLWebApps.DAL.Models;
using NavigateURLWebApps.DAL.Gatway;
using NavigateURLWebApps.DAL.Models.ViewModels;

namespace NavigateURLWebApps.BLL
{
    public class StudentManager
    {
        StudentGatway StudentGatway1;
        public StudentManager()
        {
            StudentGatway1 = new StudentGatway();
        }
        
        public string Save(Student student1)
        {

            if(StudentGatway1.IsRegExists(student1.RegNo)==false)
          {
                int rowaffect = StudentGatway1.Save(student1);
                if (rowaffect > 0)
                {
                    return "Save sucessful";
                }
                else
                {
                    return "Save failed";
                }
                
            }

          else
          {
               return "Reg no already exits.";
          }

        }

        public List<StudentViewModel> GetAllStudents()
        {
            List<StudentViewModel > students = StudentGatway1.GetAllStudent();
            return students;
        }

        public Student GetStudentById(int id)
        {
           return  StudentGatway1.GetStudentById(id);
        }
     public string UpdateByStudentId(Student student)
        {
            int rowaffect = StudentGatway1.UpdateByStudentId(student);

         if(rowaffect>0)
         {
             return "Update successful";
         }
         else
         {
             return "Update failed";
         }

        }
        public string Delete(int id)
     {
         int rowaffect = StudentGatway1.Delete(id);

            if(rowaffect>0)
            {
                return "Delete sucessful";
            }
            else
            {
                return "Delete failed"; 
            }
     }
    }
}