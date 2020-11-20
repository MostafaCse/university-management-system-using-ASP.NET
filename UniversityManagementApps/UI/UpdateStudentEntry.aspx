<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateStudentEntry.aspx.cs" Inherits="NavigateURLWebApps.UI.UpdateStudentEntry" %>

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
             <asp:HiddenField ID="IdHiddenField" runat="server" />

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
                 <asp:TextBox ID="DepartentTextBox" runat="server"></asp:TextBox>
             </td>
         </tr>
           <tr>
             <td>
                 <asp:Button ID="UpdateButton" runat="server" Text="Update" OnClick="UpdateButton_Click" />
                 <asp:Button ID="DeleteButton" runat="server" Text="Delete" OnClick="DeleteButton_Click" />
             </td>
         </tr>
        <tr>
            <td>
                <asp:Label ID="OutputLabel" runat="server" Text=""></asp:Label>
            </td>
            
        </tr>
     </table>
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Back</asp:LinkButton>
    </form>
</body>
</html>
