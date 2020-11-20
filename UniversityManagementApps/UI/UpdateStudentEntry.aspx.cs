using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NavigateURLWebApps.BLL;
using NavigateURLWebApps.DAL.Models;
using NavigateURLWebApps.DAL.Gatway;

namespace NavigateURLWebApps.UI
{
    public partial class UpdateStudentEntry : System.Web.UI.Page
    {
        StudentManager studentmanger;
        public UpdateStudentEntry()
        {
            studentmanger = new StudentManager();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                int id = Convert.ToInt32(Request.QueryString["Id"]);
                //  Student student = studentmanger.GetStudentById(id);
                FormLoadById(id);
             //   Response.Write(id);
            }
        
        }

      

   public void FormLoadById(int id)
        {
            Student student = studentmanger.GetStudentById(id);
            IdHiddenField.Value = student.Id.ToString();
            RegNoTextBox.Text = student.RegNo;
            NameTextBox.Text = student.Name;
            EmailTextBox.Text = student.Email;
            AddressTextBox.Text = student.Address;
         //   DepartentTextBox.Text = student.DepartmentId;
            PhoneTextBox.Text = student.Phone;
        }

   protected void UpdateButton_Click(object sender, EventArgs e)
   {
       Student student = new Student();
       student.Id = Convert.ToInt32(IdHiddenField.Value);
       student.RegNo = RegNoTextBox.Text;
       student.Name = NameTextBox.Text;
       student.Email = EmailTextBox.Text;
       student.Phone = PhoneTextBox.Text;
       student.Address = AddressTextBox.Text;
      // student.DepartmentId = DepartentTextBox.Text;

    studentmanger.UpdateByStudentId(student);
    Response.Redirect("ShowAllStudent.aspx");
   }

   protected void LinkButton1_Click(object sender, EventArgs e)
   {
       Response.Redirect("ShowAllStudent.aspx");
   }

   protected void DeleteButton_Click(object sender, EventArgs e)
   {

   }
    }
}