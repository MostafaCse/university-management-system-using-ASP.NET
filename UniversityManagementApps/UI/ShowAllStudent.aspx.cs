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
    public partial class ShowAllStudent : System.Web.UI.Page
    {
        StudentManager Studentmanager;
        public ShowAllStudent()
        {
            Studentmanager = new StudentManager();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
           
            StudentGridView.DataSource = Studentmanager.GetAllStudents();
            StudentGridView.DataBind();
        }

        protected void StudentGridView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
          //  Response.Write("Hello world");
            LinkButton UpdataLinkButton =(LinkButton) sender;
            DataControlFieldCell DataControlFieldCel = (DataControlFieldCell) UpdataLinkButton.Parent;
            GridViewRow GridViewRow =(GridViewRow) DataControlFieldCel.Parent;
            HiddenField idHiddenField = (HiddenField)GridViewRow.FindControl("IdHiddenField");
            int id =Convert.ToInt32( idHiddenField.Value);
           // Response.Write(id);
            Response.Redirect("UpdateStudentEntry.aspx?id="+id);



        }

        protected void DeleteLinkButton_Click(object sender, EventArgs e)
        {
            LinkButton DeleteLinkButton = (LinkButton)sender;
            DataControlFieldCell dataControlFieldCell1 = (DataControlFieldCell)DeleteLinkButton.Parent;
            GridViewRow GridViewRow1 = (GridViewRow)dataControlFieldCell1.Parent;
            HiddenField IdHiddenField = (HiddenField)GridViewRow1.FindControl("IdHiddenField");
            int id = Convert.ToInt32(IdHiddenField.Value);

            Studentmanager.Delete(id);


        }

    
    }
}