<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Session.aspx.cs" Inherits="ThreadDemo.Session" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sessions</title>
</head>
<body id="BodyTag" runat="server">
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList runat="server" ID="ColorSelector" AutoPostBack="true" OnSelectedIndexChanged="ColorSelector_IndexChanged" >
                <asp:ListItem Value="White" Selected="True">Select color...</asp:ListItem>
                <asp:ListItem Value="Red">Red</asp:ListItem>
                <asp:ListItem Value="Green">Green</asp:ListItem>
                <asp:ListItem Value="Blue">Blue</asp:ListItem>
            </asp:DropDownList>
        </div>
    </form>
</body>
</html>
