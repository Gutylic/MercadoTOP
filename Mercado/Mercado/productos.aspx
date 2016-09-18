<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="productos.aspx.cs" Inherits="Mercado.productos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
     <head runat="server">
    
    <title>MercadoTop</title>

    
    

    
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.0/jquery.min.js"></script>
    <!-- Latest compiled and minified CSS -->
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">
   <!-- Latest compiled and minified JavaScript -->
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>
    

    
    

    
        <style type="text/css">
            .auto-style1 {
                width: 97px;
            }
        </style>

    
    

    
        

    
    
    

    
        </head>

<body style="background-color:#e8e7e7;">
     <form id="form1" runat="server" >
    <header style="background-color: #FFD24D;border-bottom: 1px solid #D9D9D9;height: 54px;position: absolute;top: 0;left: 0;right: 0;z-index: 999; padding-top:5px">
        
        
        
        
        
       
        
        <div class="input-group col-xs-12" >
            
            <table style="width: 100%;">
                <tr>
                    <td style="width:20%">LOGO</td>
                    <td style="width:40%">
                        
              </td>          
                    
                </tr>
               
            </table>
</div>
        



        
    
    </header>
<div class="container">
    <!-- Publicidad -->
    <section style="padding: 100px">
        
            
    <div class="col-xs-12" style="background-color:white; border: solid 1px silver; border-radius: 5px; top: 0px; left: 0px; height: 524px; width:100%">

        <img src="img/producto.png" style="width:100%" />
    
        <div class="row grande" style=" width:106%; height:90%; margin-right:0px">

            <div class="col-xs-4" style="height:40px">
                <div class="row">

                    <div class="col-xs-6 autos"><asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="img/autosM.png" /></div>
                    <div class="col-xs-6 casas"><asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="img/casasM.png" /></div>
                       
                </div>
                <div class="row">

                    <div class="col-xs-6 servicios"><asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="img/productos.png" /></div>
                    <div class="col-xs-6 productos"><asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="img/serviciosM.png"  /></div>
                       
                </div>
            </div>
            <div class="col-xs-4" style="height:40px">
                <div class ="row">
                    <div class="col-xs-12"><asp:DropDownList ID="Categoria1" AutoPostBack="true" Visible="true" runat="server" Height="32px" Width="255px" style="margin-top:25px; margin-left: 20px" OnSelectedIndexChanged="Categoria1_SelectedIndexChanged"></asp:DropDownList></div>
                    <div class="col-xs-12"><asp:DropDownList ID="Categoria2" AutoPostBack="true" Visible="false" runat="server" Height="32px" Width="255px" style="margin-top:25px; margin-left: 20px" OnSelectedIndexChanged="Categoria2_SelectedIndexChanged" ></asp:DropDownList></div>
                    <div class="col-xs-12"><asp:DropDownList ID="Categoria3" AutoPostBack="true" Visible="false" runat="server" Height="32px" Width="255px" style="margin-top:25px; margin-left: 20px" OnSelectedIndexChanged="Categoria3_SelectedIndexChanged"></asp:DropDownList></div>
                    <div class="col-xs-12"><asp:DropDownList ID="Categoria4" AutoPostBack="true" Visible="false" runat="server" Height="32px" Width="255px" style="margin-top:25px; margin-left: 20px" OnSelectedIndexChanged="Categoria4_SelectedIndexChanged"></asp:DropDownList></div>
                    <div class="col-xs-12"><asp:DropDownList ID="Categoria5" AutoPostBack="true" Visible="false" runat="server" Height="32px" Width="255px" style="margin-top:25px; margin-left: 20px" OnSelectedIndexChanged="Categoria5_SelectedIndexChanged" ></asp:DropDownList></div>
                </div>
            </div>
            <div class="col-xs-4 listo" style="height:40px"><asp:ImageButton ID="ImageOk" Visible="false" runat="server" ImageUrl="img/Listo.png" OnClick="ImageOk_Click"/></div>

        </div>
      
        
                    
    <div class="pie" style="margin-top:-20px; font-size:10px">Asegúrate de que tu publicación cumpla con las <asp:LinkButton ID="LinkButton1" runat="server">Políticas de MercadoTop</asp:LinkButton></div>           
                   
         </div>
        


     
        




 
       <%--<table style="margin-top:50px" >
                        <tr>
                            <td>
                                <asp:ImageButton ID="ImageButton1" ImageUrl="img/autos.png" runat="server" Height="80%" Width="80%" />
                            </td>
                            <td >
                                <asp:ImageButton ID="ImageButton3" ImageUrl="img/casas.png" runat="server" Height="80%" Width="80%" />
                            </td>
                            <td ><asp:DropDownList ID="DropDownList1" runat="server" Height="48px" Width="285px"></asp:DropDownList>


                                <asp:DropDownList ID="DropDownList2" runat="server" Height="48px" Width="285px" style="margin-top:10px"></asp:DropDownList>

                                <asp:DropDownList ID="DropDownList3" runat="server" Height="48px" Width="285px" style="margin-top:10px"></asp:DropDownList>

                                <asp:DropDownList ID="DropDownList4" runat="server" Height="48px" Width="285px" style="margin-top:10px"></asp:DropDownList>

                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="img/servicios.png" Height="80%" Width="80%" />
                            </td>
                            <td>
                                <asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="img/productos.png" Height="80%" Width="80%" />
                            </td>
                        </tr>
                       <td ><asp:DropDownList ID="DropDownList5" runat="server" Height="48px" Width="285px"></asp:DropDownList>


                                <asp:DropDownList ID="DropDownList6" runat="server" Height="48px" Width="285px" style="margin-top:10px"></asp:DropDownList>

                                <asp:DropDownList ID="DropDownList7" runat="server" Height="48px" Width="285px" style="margin-top:10px"></asp:DropDownList>

                                <asp:DropDownList ID="DropDownList8" runat="server" Height="48px" Width="285px" style="margin-top:10px"></asp:DropDownList>

                            </td>
                    </table>--%>

           

  
   
        </section>
  
       </div>
    

  
    

  
</form>
</body>
</html>
