<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrationForm.aspx.cs" Inherits="SmarQWebForms.RegistrationForm" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .center {
            margin: auto;
            width: 40%;
            border: 1px solid black;
            padding: 10px;
        }


        .registration {
            margin: auto;
            border: 0px solid black;
            padding: 5px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
       


            <div class="center">
                <div class="registration">
                    Registration Page
                </div>

            </div>
            <div class="center">
                <table>
                    <tr>
                        <td>Please enter your Mobile No#
                        </td>
                        <td>
                            <input type="text" runat="server" id="txtMobileNumber" />
                        </td>
                        <td>
                            <input type="submit" runat="server" id="btnSendOTP" onserverclick="btnSendOTP_ServerClick1" value="Send OTP" />

                        </td>
                        </tr>
                    <tr>
                        <td>
                            OTP
                        </td>
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
                        <td></td>
                        <td>
                            <input class="btnStyle" type="submit" value="Register" runat="server" id="btnregister" onserverclick="btnregister_ServerClick" />
                        </td>
                    </tr>

                </table>
            </div>
        
    </form>
</body>
</html>
