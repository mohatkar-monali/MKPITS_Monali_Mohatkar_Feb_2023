<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="signup.aspx.cs" Inherits="aspwebshopsy.signup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border-collapse: collapse;
        }
        .auto-style2 {
            width: 43%;
            border-collapse: collapse;
        }
        .auto-style3 {
            text-align: left;
            width: 188px;
        }
        .auto-style4 {
            width: 188px;
        }
        .auto-style5 {
            text-align: left;
            width: 253px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h1 align="center">Sign Up Form<br />
         <table class="auto-style2" align="center">
             <tr>
                 <td class="auto-style3">Name</td>
                 <td class="auto-style5">
                     <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                 </td>
             </tr>
             <tr>
                 <td class="auto-style3">Password</td>
                 <td class="auto-style5">
                     <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                 </td>
             </tr>
             <tr>
                 <td class="auto-style4">&nbsp;</td>
                 <td class="auto-style5">
                     <asp:Button ID="Button1" runat="server" Text="Sign Up" />
                 </td>
             </tr>
         </table>
         <table class="auto-style1">
         </table>
     </h1>
</asp:Content>
