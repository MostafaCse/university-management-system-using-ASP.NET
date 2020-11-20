<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentEntryUI.aspx.cs" Inherits="NavigateURLWebApps.UI.StudentEntryUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <table>
       

         <tr>
             <td>
             
                 <asp:Label ID="Label1" runat="server" Text="RegNo"></asp:Label>
             </td>
             <td>
                 <asp:TextBox ID="RegNoTextBox" runat="server"></asp:TextBox>
             </td>
         </tr>
          <tr>
             <td>
                 <asp:Label ID="Label5" runat="server" Text="Name"></asp:Label>
             </td>
             <td>
                 <asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox>
             </td>
         </tr>
          <tr>
             <td>
                 <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
             </td>
             <td>
                 <asp:TextBox ID="EmailTextBox" runat="server"></asp:TextBox>
             </td>
         </tr>
            <tr>
             <td>
                 <asp:Label ID="NameLabel" runat="server" Text="Phone"></asp:Label>
             </td>
             <td>
                 <asp:TextBox ID="PhoneTextBox" runat="server"></asp:TextBox>
             </td>
         </tr>
          <tr>
             <td>
                 <asp:Label ID="Label4" runat="server" Text="Address"></asp:Label>
             </td>
             <td>
                 <asp:TextBox ID="AddressTextBox" runat="server"></asp:TextBox>
             </td>
         </tr>
           <tr>
             <td>
                 <asp:Label ID="Label3" runat="server" Text="Department"></asp:Label>
             </td>
             <td>
                 <asp:DropDownList ID="DepartmentDropDownList1" runat="server">
                 </asp:DropDownList>
             </td>
         </tr>
           <tr>
             <td>
                 <asp:Button ID="SaveButton" runat="server" Text="Save" OnClick="SaveButton_Click" />
                 
             </td>
         </tr>
        <tr>
            <td>
                <asp:Label ID="OutputLabel" runat="server" Text=""></asp:Label>
            </td>
        </tr>
     </table>
         <asp:HyperLink ID="BackHyperLink" runat="server" NavigateUrl="~/UI/MainUI.aspx">Back</asp:HyperLink>
    </form>
</body>
</html>
