<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NumberToWord.aspx.cs" Inherits="NumberToWord.NumberToWord" %>

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
                    <td>Enter Number
                    </td>
                    <td>
                        <asp:TextBox ID="txtnotoword" runat="server" MaxLength="9"></asp:TextBox>
                       
                    </td>
                    <td>
                        <asp:Label ID="lblmsg" runat="server" Text="Label" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="ConvertNumberToWord" runat="server" Text="ConvertNumberToWord" OnClick="ConvertNumberToWord_Click" />
                    </td>
                </tr>
                <tr>
                    <td>Result
                    </td>
                    <td>
                        <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
                    </td>

                </tr>
            </table>
        </div>
    </form>
</body>
</html>
