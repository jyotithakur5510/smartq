<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Service.aspx.cs" Inherits="SmarQWebForms.Service" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <h2>Choose your Services</h2>

                <%--<tr>
                <td>
<input type="checkbox" value="Blood Test" /> Blood Test
                </td>
            </tr>
            <tr>
                <td>
                    <input type= "checkbox" value="Consulting" />Consulting
                </td>
            </tr>
            <tr>
                <td>
                    <input type="checkbox" value="Operation" />Operation
                </td>
            </tr>
            <tr>
                <td>
                    <input type="checkbox" value="Checking" />Checking

                </td>
            </tr>--%>
                <tr>
                    <td>
                        <asp:CheckBoxList ID="chkServiceList" runat="server"></asp:CheckBoxList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <input text="submit" value="Next" />
                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
