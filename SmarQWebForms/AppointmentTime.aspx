<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AppointmentTime.aspx.cs" Inherits="SmarQWebForms.AppointmentTime" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
    <ul>
        <li>
            Timing
        </li>
    </ul>
    <table>
        <tr>
            <td><input type ="text" value="9:00 - 10:00" /></td>
            
            <td>
                <input type ="text" value="10:00 - 11:00" />
            </td>
            <td>
                <input type ="text" value="11:00 - 12:00" />
            </td>
        </tr>
        <tr><
            <td> <input type ="text" value="5:00 - 6:00" /></td>
            <td> <input type ="text" value="5:00 - 6:00" /></td>
            <td><input type ="text" value="6:00 - 7:00" /></td>
           <td> <input type ="text" value="7:00 - 8:00" /></td>
        </tr>
       
        <td><input type ="submit" value="Next" /></td>
    </table>
</div>
        </div>
    </form>
</body>
</html>
