<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TicketForm.aspx.cs" Inherits="SmarQWebForms.TicketForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Styles/smartq.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
        <div text-align:center>


            <table border="1">
                <tr>
                    <td>Ticket Number
                    </td>
                    <td>
                        <label runat="server" id="lblTicketNumber"></label>
                    </td>
                </tr>
                <tr>
                    <td>Client Name
                    </td>
                    <td>
                        <label runat="server" id="lblClientName"></label>
                    </td>
                </tr>

                <tr>
                    <td>Service Name
                    </td>
                    <td>
                        <label runat="server" id="lblServiceName"></label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <input type="button" value="Print" />
                    </td>
                    <td>
                        <input type="button" value="Download" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
