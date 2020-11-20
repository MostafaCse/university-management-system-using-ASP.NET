<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowAllStudent.aspx.cs" Inherits="NavigateURLWebApps.UI.ShowAllStudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
   
        <asp:GridView ID="StudentGridView" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:TemplateField HeaderText="RegNo">
                    <ItemTemplate>
                        <asp:HiddenField ID="IdHiddenField" runat="server" Value='<%#Eval("Id") %>' />

                        <asp:Label runat="server" Text='<%#Eval("RegNo") %>'>
                        </asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                  <asp:TemplateField HeaderText="Name">
                    <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("StudentName") %>'>
                        </asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                  <asp:TemplateField HeaderText="Email">
                    <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("Email") %>'>
                        </asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

               <asp:TemplateField HeaderText="Address">
                    <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("Address") %>'>
                        </asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                 <asp:TemplateField HeaderText="Department">
                    <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("DepartmentName") %>'>
                        </asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                  <asp:TemplateField HeaderText="Code">
                    <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("Code") %>'>
                        </asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                   <asp:TemplateField HeaderText="Action">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Update</asp:LinkButton>
                    </ItemTemplate>

                </asp:TemplateField>
                   <asp:TemplateField HeaderText="Action">
                    <ItemTemplate>
                        <asp:LinkButton ID="DeleteLinkButton" runat="server" OnClick="DeleteLinkButton_Click">Delete</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>

            </Columns>
              
        </asp:GridView>
        <asp:HyperLink ID="BackHyperLink" runat="server" NavigateUrl="~/UI/MainUI.aspx">Back</asp:HyperLink>
    </form>
</body>
</html>
