using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NavigateURLWebApps.DAL.Models;
using NavigateURLWebApps.DAL.Gatway;
using NavigateURLWebApps.BLL;

namespace NavigateURLWebApps.UI
{
    public partial class StudentEntryUI : System.Web.UI.Page
    {
        DepartmentManager departmentManager = new DepartmentManager();
        protected void Page_Load(object sender, EventArgs e)
        {
           if(!IsPostBack)
           {
               DepartmentDropDownList1.DataSource = departmentManager.GetAllStudent();
               DepartmentDropDownList1.DataTextField = "Name";
               DepartmentDropDownList1.DataValueField = "Id";
               DepartmentDropDownList1.DataBind();
           }
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            Student student1 = new Student();
            student1.RegNo = RegNoTextBox.Text;
            student1.Name = NameTextBox.Text;
            student1.Email = EmailTextBox.Text;
            student1.Phone = PhoneTextBox.Text;
            student1.Address = AddressTextBox.Text;
            student1.DepartmentId =Convert.ToInt32( DepartmentDropDownList1.SelectedValue);
       //     student1.DepartmentId = DepartentTextBox.Text;

            NameTextBox.Text = "";
            RegNoTextBox.Text = "";
            EmailTextBox.Text = "";
            PhoneTextBox.Text = "";
            AddressTextBox.Text = "";

          //  DepartentTextBox.Text = "";
            StudentManager Studentmanager = new StudentManager();
        string result= Studentmanager.Save(student1);
        OutputLabel.Text = result;
        }

      
    }
}