<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="SmarQWebForms.LoginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td>Mobile Number</td>
                <td> <input type="text" id="txtMobileNumber" runat="server" /></td>
                <td><input type="button" runat="server" id="btnSendOTP" onserverclick="btnSendOTP_Click" value="Send OTP" /> </td>
            </tr>
            <tr>
                <td> </td>
                <td>  <input type="text" runat="server" id="txtOTP" /></td>
                <td>
                    <input type="button" runat="server" id="btnSubmit" onserverclick="btnVerifyOTP_Click" value="Verify OTP" />
                </td>
            </tr>
            <tr>
                <td>
                   </td>
                <td>
                    

            </tr>
        </table>
    </form>
</body>
</html>
