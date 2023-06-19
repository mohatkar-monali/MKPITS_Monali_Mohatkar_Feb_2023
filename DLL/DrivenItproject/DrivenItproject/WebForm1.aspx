<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DrivenItproject.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <p>
    Transaction form</p>
<p>
    Item Id
    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Itemdesc" DataValueField="ItemId">
    </asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DrivenItdbConnectionString %>" ProviderName="<%$ ConnectionStrings:DrivenItdbConnectionString.ProviderName %>" SelectCommand="SELECT [ItemId], [Itemdesc] FROM [ItemMaster]"></asp:SqlDataSource>
</p>
<p>
    Transaction Type&nbsp;
    <asp:RadioButton ID="RadioButton1" runat="server" GroupName="tt" Text="Issue" />
&nbsp;&nbsp;
    <asp:RadioButton ID="RadioButton2" runat="server" GroupName="tt" Text="Recived" />
    </p>
    <p>
        Transation&nbsp;&nbsp;&nbsp;&nbsp; Quantity
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p>
        Transaction Date
        <asp:TextBox ID="TextBox1" runat="server" TextMode="Date"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Edit" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Delete" />
    </p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Transid" DataSourceID="SqlDataSource2" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                <asp:BoundField DataField="Transid" HeaderText="Transid" InsertVisible="False" ReadOnly="True" SortExpression="Transid" />
                <asp:BoundField DataField="ItemId" HeaderText="ItemId" SortExpression="ItemId" />
                <asp:BoundField DataField="TransType" HeaderText="TransType" SortExpression="TransType" />
                <asp:BoundField DataField="TransQty" HeaderText="TransQty" SortExpression="TransQty" />
                <asp:BoundField DataField="TranseDate" HeaderText="TranseDate" SortExpression="TranseDate" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:DrivenItdbConnectionString %>" DeleteCommand="DELETE FROM [Transactions] WHERE [Transid] = @Transid" InsertCommand="INSERT INTO [Transactions] ([ItemId], [TransType], [TransQty], [TranseDate]) VALUES (@ItemId, @TransType, @TransQty, @TranseDate)" SelectCommand="SELECT [Transid], [ItemId], [TransType], [TransQty], [TranseDate] FROM [Transactions]" UpdateCommand="UPDATE [Transactions] SET [ItemId] = @ItemId, [TransType] = @TransType, [TransQty] = @TransQty, [TranseDate] = @TranseDate WHERE [Transid] = @Transid">
            <DeleteParameters>
                <asp:Parameter Name="Transid" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="ItemId" Type="Int32" />
                <asp:Parameter Name="TransType" Type="String" />
                <asp:Parameter Name="TransQty" Type="Int32" />
                <asp:Parameter Name="TranseDate" Type="DateTime" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="ItemId" Type="Int32" />
                <asp:Parameter Name="TransType" Type="String" />
                <asp:Parameter Name="TransQty" Type="Int32" />
                <asp:Parameter Name="TranseDate" Type="DateTime" />
                <asp:Parameter Name="Transid" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </p>
</asp:Content>
