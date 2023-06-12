﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="aspcashemi.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Load" />
            <br />
            <br />
            Total Amount&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            Paid Amount&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <asp:RadioButton ID="RadioButton1" runat="server" GroupName="mode" Text="Cash" />
            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="mode" Text="Emi" />
            <br />
            <asp:GridView ID="GridView2" runat="server">
            </asp:GridView>
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Show Emi" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
