<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditService.aspx.cs" Inherits="SmarQWebForms.EditService" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            EDIT WORK HERE
        </div>
        <div>
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
        </div>
       <tr>
    <td>
                ServiceName
            </td>
        
        <td>
            <input type="text" runat="server" id="txtServiceName" />
           <div>
          

            </div>
        </td>
            </tr>
    </form>
</body>
</html>
