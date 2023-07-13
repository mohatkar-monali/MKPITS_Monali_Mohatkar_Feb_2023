<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ValidateForm.aspx.cs" Inherits="ValidationwithJS.Kycform" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%; border-collapse: collapse">
        <tr>
            <td style="width: 229px">
                <br />
                Kyc Registration Form</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 229px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 229px">&nbsp;&nbsp;&nbsp;&nbsp; First Name</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Width="318px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 229px; height: 29px">&nbsp;&nbsp;&nbsp; &nbsp;</td>
            <td style="height: 29px"></td>
        </tr>
        <tr>
            <td style="width: 229px">&nbsp;&nbsp;&nbsp; Last Name&nbsp;</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" Width="315px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 229px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 229px">&nbsp;&nbsp; Email</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server" Width="310px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 229px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 229px">&nbsp;&nbsp; Mobile No&nbsp;</td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 229px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 229px">&nbsp;&nbsp; Gender&nbsp;</td>
            <td>
                <asp:RadioButton ID="RadioButton1" runat="server" GroupName="Gender" Text="Male" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RadioButton ID="RadioButton2" runat="server" GroupName="Gender" Text="Female" />
            </td>
        </tr>
        <tr>
            <td style="width: 229px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 229px">&nbsp;</td>
            <td>
                <asp:Button ID="Button1" OnClientClick="return Validateform();" runat="server" Text="Submit" Width="128px" OnClick="Button1_Click" />
                <br />
                <br />
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
    </table>

    <script type="text/javascript">
        function Validateform()
        {
       
            var firstname = document.getElementById('<%=TextBox1.ClientID%>').value;
            if (firstname.trim() === '') {
                alert("Please enter first name");
                document.getElementById('<%=TextBox1.ClientID%>').focus;
                return false;
            }
            var fname = /^[A-Za-z]+$/;
            if (firstname.match(fname)) {

            }
            else
            {
                alert("Please enter only characters in first name");
            }
           
        }
    </script>

</asp:Content>
