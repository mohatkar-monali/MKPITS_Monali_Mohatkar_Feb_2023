<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Messhosoppingsite._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <div class="container">  
            <div class="row">  
            <div class="col-md-6" style="background-color:#EBF5F8;padding:50px";><h2><b></b>Lowest Prices<br />
                Best Quality Shopping</h2>
             
                <div class="row">
  <div class="column" style="background-color:white; text-align:center";>
    <table>
      <tr>
        <td>
            <center>
            <img src="https://images.meesho.com/images/pow/freeDelivery_jamun.svg" /><b>Free Delivery&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                </center>
        </td>
        <td>  <img src="https://images.meesho.com/images/pow/cod_jamun.svg" /><b>Cash On Delivery</b>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp</td>
        <td> <img src="https://images.meesho.com/images/pow/easyReturns_jamun.svg" /><b>Easy Return</b></td>
      </tr>
    </table>
  </div>

</div>
</div>  
                                     <div class ="col-md=col-6"><img src="image1.jpg" style="width:400px;height:250px;" /></div>

 </div >

                

</div>

           <%-- <h1 id="aspnetTitle">Messho</h1>
            <p class="lead">                    Lowest Prices
Best Quality Shopping
                    </p>
           <!-- <p><a href="http://www.asp.net" class="btn btn-primary btn-md">Learn more &raquo;</a></p>-->
        </section>
 
        <div class="row">
            <section class="col-md-4" aria-labelledby="gettingStartedTitle">
                <h2 id="gettingStartedTitle">Messho</h2>
                <p>
                    Lowest Prices
Best Quality Shopping
                    
                    
                    <br /><br />
    
                </p>
                <p>
                    <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301948"></a>
                </p>
            </section>
            <section class="col-md-4" aria-labelledby="librariesTitle" >
                <h2 id="librariesTitle"></h2>
                <p>
                     Register as a Meesho Supplier 
                          
              
                </p>
                <p>
                    <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301949"></a>
                </p>
           --%> </section>
            <%--<section class="col-md-4" aria-labelledby="hostingTitle">
                <h2 id="hostingTitle"></h2>
                <p>
                      <img src="image1.jpg" style="width:400px;height:250px;" />

                </p>
                <p>
                    <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301950"></a>
                </p>
            </section>--%>
        
        <hr>.
        <div class="row">
            <h1 align=center>------------------ Top Categories to choose from ---------------</h1>
           </div>
        <hr>
        <div>
                <asp:DataList ID="DataList1" runat="server" RepeatColumns="4" RepeatDirection="Horizontal" Width="100%">
               
              <ItemTemplate>  
                <table cellpadding="2" cellspacing="0" border="1" style="width: 300px; height: 400px;   
                border: dashed 2px #04AFEF; background-color: #FFFFFF">  
                    <tr>  
                        <td align="center">  
                            <a href='<%#Eval("productid","productdetails.aspx?productid={0}") %>'>
                             <asp:Image ID="Image1" ImageUrl='<%# Bind("imagename", "~/images/{0}") %>' runat="server" Height="100"
                        Width="100" />
                            </a>
                              
                        </td>  
                    </tr>  
                      <tr>
                        <td align="center">
                            <span > <%# Eval("productname") %></span><br /> 
                             <span > <%# Eval("productdesc") %></span><br /> 
                             <span >Rs. <%# Eval("productprice") %> onwards</span><br /> 
                            

                        </td>
                    </tr>
                </table>  
            </ItemTemplate>  
           </asp:DataList>
            </div>
    </main>

</asp:Content>
