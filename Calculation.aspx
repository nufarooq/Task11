<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculation.aspx.cs" Inherits="AdditionSubstractionApp.Calculation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Enter the Value of a: 
        <asp:TextBox ID="txtNum1" runat="server" />
        <br />
        Enter the Value of b:
        <asp:TextBox ID="txtNum2" runat="server" />
        <br />
            <asp:Button ID="btnAdd" Text="Add" OnClick="button_add" runat="server" />
            <asp:Button ID="btnSubtract" Text="Subtract" OnClick="button_sub" runat="server" />
    </form>
</body>
</html>
