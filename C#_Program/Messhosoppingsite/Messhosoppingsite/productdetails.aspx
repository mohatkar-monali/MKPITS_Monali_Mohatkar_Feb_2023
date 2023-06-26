<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="productdetails.aspx.cs" Inherits="Messhosoppingsite.productdetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style> 
            td {
  padding: 15px;
 /* border: 1px solid lightgray;
  border-collapse: collapse;*/
}
        </style>
    <asp:DataList ID="DataList1" runat="server" Width="100%">
         <ItemTemplate>  
                <table cellpadding="2" cellspacing="0" border="1" style="width: 100%; height: 100px;   
                border: dashed 0px #04AFEF; background-color: #FFFFFF;  border: 1px solid lightgray;">  
                    <tr>  
                        <td >  
                            <table width="100%">
                                <tr>
                                    <td align="center">
                                          <a href='<%#Eval("productid","productdetails.aspx?productid={0}") %>'>
                                          <asp:Image ID="Image1" ImageUrl='<%# Bind("imagename", "~/images/{0}") %>' runat="server" Height="250"
                                           Width="200" />
                                           </a>
                                        </td>
                                    </tr>
                                    <tr align="center">
                                    <td>
                                        <a style="border:1px;color:white;text-decoration:none;padding:10px;border-radius:10px;background-color:purple;" href='<%# Eval("productid","cart.aspx?productid={0}") %>'>Add To Cart</a>
                                        &nbsp &nbsp
                                        <a  style="border:1px;color:white;text-decoration:none;padding:10px;border-radius:10px;background-color:purple;" href="cart.aspx">Buy Now</a>
                                    </td>
                                    </tr>
                              </table>
                        </td>  
                 
                        <td >
                           
                            <table width="100%" style=" border: 1px solid lightgray;">
                              
                                <tr>
                                    <td>
                            <span > <%# Eval("productname") %></span><br /> 
                            
                             <span >Rs. <%# Eval("productprice") %> onwards</span><br /> 
                            Free Delivery
                                        </td>
                                    </tr>
                                </table>
                            <table width="100%" style=" border: 1px solid lightgray;">
                                <tr>
                                    <td>
                                        <b>Product Details:</b><br/>
                                     Name:<span > <%# Eval("productname") %></span><br /> 

                                      Description:<span > <%# Eval("productdesc") %></span><br /> 
                                          Size : M, L ,XL, XXL </br>
                                          Country of origin : India
                                    </td>
                                 </tr>
                              
                                </table>
                        </td>
                    </tr>
                </table>  
            </ItemTemplate>  
    </asp:DataList>
</asp:Content>
