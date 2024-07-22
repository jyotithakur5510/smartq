<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrationForm.aspx.cs" Inherits="SmarQWebForms.RegistrationForm" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Please enter your Mobile Number
                    </td>
                    <td>
                        <input type="text" runat="server" id="txtMobileNumber" />
                    </td>
                    <td>
                        <input type="submit" runat="server" id="btnSendOTP" onserverclick="btnSendOTP_ServerClick1" value="Send OTP" /></td>
                    <td>
                        <input type="text" runat="server" id="txtOTP" />
                    </td>
                    <td>
                        <input type="submit" runat="server" id="btnSubmitOTP" onserverclick="btnSubmitOTP_ServerClick" value="Submit OTP" />
                    </td>
                </tr>
                <br />
                <tr>
                    <td>Name
                    </td>
                   
                    <td>
                        <input type="text" runat="server" id="txtName" />
                    </td>


                </tr>
                <tr>
                    <td>
                        <input class="btnStyle" type="submit" value="Register" runat="server" id="btnregister" onserverclick="btnregister_ServerClick" />
                    </td>
                </tr>

            </table>
        </div>
    </form>
</body>
</html>
