<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="megaCasino.aspx.cs" Inherits="cSharp.megaCasino" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" ImageUrl="~/mega/Images/Bar.png" />
            <asp:Image ID="Image2" runat="server" ImageUrl="~/mega/Images/Bar.png" />
            <asp:Image ID="Image3" runat="server" ImageUrl="~/mega/Images/Bar.png" />
            <br />
            <br />
            <br />
            <asp:Label ID="userNameLabel" runat="server" Text="Enter your name:"></asp:Label>
&nbsp;<asp:TextBox ID="userTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            Your bet:&nbsp; <asp:TextBox ID="betTextBox" runat="server"></asp:TextBox>
&nbsp;<br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="leverButton" runat="server" OnClick="leverButton_Click" Text="Pull The Lever!" />
            <br />
            <br />
            Players Money: <asp:Label ID="playersMoneyLabel" runat="server"></asp:Label>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
            <br />
            <br />
            To Win:<br />
            1 Cherry =&nbsp; 1x your bet.<br />
            2 Cherries = 2x&#39;s your bet. <br />
            3 Cherries = 4x&#39;s your bet.<br />
            <br />
            3 - 7&#39;s = JACKPOT (100 x&#39;s your bet.)<br />
            <br />
            HOWERVER...<br />
            <br />
            Even if there is even one bar you win nothing.<br />
            <br />
&nbsp;</div>
    </form>
</body>
</html>
