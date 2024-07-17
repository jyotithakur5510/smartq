<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ServiceMasterForm.aspx.cs" Inherits="SmarQWebForms.ServiceMasterForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="grdService" runat="server" AutoGenerateColumns="false" OnRowDataBound="grdService_RowDataBound" OnRowCommand="grdService_RowCommand">
                <Columns>
                    <asp:TemplateField HeaderText="Service Name">
                        <ItemTemplate>
                            <asp:Label ID="lblServiceName" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "ServiceName")%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Edit">
                        <ItemTemplate>
                            <asp:LinkButton ID="editLinkButton" runat="server">Edit</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Delete">
                        <ItemTemplate>
                            <asp:LinkButton runat="server">Delete</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>


        </div>
    </form>
</body>
</html>
