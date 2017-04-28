<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="helperMethod.aspx.cs" Inherits="cSharp.helperMethod" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Convert To Cups<br />
            <br />
&nbsp;<asp:TextBox ID="quantityTextBox" runat="server" AutoPostBack="True" OnTextChanged="quantityTextBox_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:RadioButton ID="fromCupsRadio" runat="server" AutoPostBack="True" Text="Cups" GroupName="fromGroup" OnCheckedChanged="fromCupsRadio_CheckedChanged" />
            <br />
            <asp:RadioButton ID="fromPintsRadio" runat="server" AutoPostBack="True" Text="Pints" GroupName="fromGroup" OnCheckedChanged="fromPintsRadio_CheckedChanged" />
            <br />
            <asp:RadioButton ID="fromQuartsRadio" runat="server" AutoPostBack="True" Text="Quarts" GroupName="fromGroup" OnCheckedChanged="fromQuartsRadio_CheckedChanged" />
            <br />
            <asp:RadioButton ID="fromGallonsRadio" runat="server" AutoPostBack="True" Text="Gallons" GroupName="fromGroup" OnCheckedChanged="fromGallonsRadio_CheckedChanged" />
            <br />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
