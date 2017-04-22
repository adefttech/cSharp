<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="challenge23.aspx.cs" Inherits="cSharp.challenge23" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/epic-spies-logo.jpg" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Font-Names="Calibri" Font-Size="X-Large" Text="Asset Performance Tracker"></asp:Label>
        </div>
        Asset Name:
        <asp:TextBox ID="assetNameTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        Elections Rigged:
        <asp:TextBox ID="electionsRiggedTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        Acts of subterfuge performed:
        <asp:TextBox ID="subterfugePerformedTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="addButton" runat="server" OnClick="addButton_Click" Text="Add Asset" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server" Text="..."></asp:Label>
        <br />
    </form>
</body>
</html>
