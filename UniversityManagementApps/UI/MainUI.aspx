<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainUI.aspx.cs" Inherits="NavigateURLWebApps.UI.MainUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h3>please click which link do you want to acess?</h3>
        <asp:HyperLink ID="StudentEntryHyperLink" runat="server" NavigateUrl="~/UI/StudentEntryUI.aspx" >Student Entry</asp:HyperLink>
        <br />
        <br />
        <asp:HyperLink ID="ShowAllStudentHyperLink" runat="server" NavigateUrl="~/UI/ShowAllStudent.aspx">Show All Student</asp:HyperLink>
    </div> 
    </form>
</body>
</html>
