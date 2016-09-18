<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="panelUsuario.aspx.cs" Inherits="Mercado.panelUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    
    <title>MercadoTop</title>

    <!-- Bootstrap Core CSS -->
    <%--<link href="vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">

    <!-- Theme CSS -->
    <link href="css/freelancer.min.css" rel="stylesheet">

    <!-- Custom Fonts -->
    <link href="vendor/font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css">
    <link href="https://fonts.googleapis.com/css?family=Montserrat:400,700" rel="stylesheet" type="text/css">
    <link href="https://fonts.googleapis.com/css?family=Lato:400,700,400italic,700italic" rel="stylesheet" type="text/css">--%>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.0/jquery.min.js"></script>
    <!-- Latest compiled and minified CSS -->
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">
   <!-- Latest compiled and minified JavaScript -->
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>
    


</head>

<body style="background:#e8e7e7">
     <form id="form1" runat="server" >
    <header style=" background-color: #FFD24D;border-bottom: 1px solid #D9D9D9;height: 54px;position: absolute;top: 0;left: 0;right: 0;z-index: 999; padding-top:5px">
        
        
        
        
        
       
        
    <div class="input-group col-xs-12" >
            
            <table style="width: 100%;">
                <tr>
                    <td style="width:20%">LOGO</td>
                    <td style="width:40%">
                        <div class="input-group" style="height:40px;margin-top: 1px;">
                          <input type="text" class="form-control" style="height:40px" aria-describedby="basic-addon2">
                          <span class="input-group-addon" id="basic-addon2"><span class="glyphicon glyphicon-search" aria-hidden="true"></span></span>
                        </div>
                    </td>    
                    <td style="padding-left:115px">
                       
                  <asp:Label ID="etiquetaNombre" runat="server" style="color:black" Text="Label"></asp:Label>

                    |
                    <asp:LinkButton ID="LinkButton1" runat="server" style="color:black" >&nbsp;Salir Ventas</asp:LinkButton>
                    </td>
                    
                </tr>
               
            </table>

    </div>        

        
    
    </header>

    <!-- Publicidad -->
    <section>
        <div class ="container">
        <asp:DataList ID="DataList_Productos" runat="server" OnItemCommand="Identificador"  CellPadding="4" ForeColor="#333333" style="margin-top:54px;" Height="249px" Width="100%">   
            <AlternatingItemStyle BackColor="White" ForeColor="#284775" />
            
           
            <ItemStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <ItemTemplate>
                <div class="row">
                    

                        <div class="col-xs-2 foto"  style="height:80px; text-align: center; "><asp:ImageButton ID="Foto_Principal" Width="80px" Height="80px"   runat="server" CommandName='<%# Eval("id_Producto")%>' ImageUrl='<%#"~/Fotos/" + Eval("ubicacionFoto1")%>' /></div>

                        <div class="col-xs-7 producto"   style="height:80px; padding-top: 25px;"><asp:Label ID="Titulo_Producto" runat="server" style="font-size:15px; 
    font-weight:bolder; text-align:left;" Text='<%# string.Concat(Eval("tituloProducto"))%>'></asp:Label></div>                        
                    
                       <div class="col-xs-1 precio" style="height:80px; padding-top: 25px;"><asp:Label ID="Precio_Producto" style="font-size:15px; 
    font-weight:bolder; text-align:left;" runat="server" Text='<%# string.Concat(Eval("precioProducto"))%>'></asp:Label></div> 
                      
                <div class="col-xs-1" style="margin-left: 35px; padding-top: 25px;">  <asp:CheckBox ID="CheckBoxBloqueo_Supervisor" runat="server" Enabled="false" Checked='<%#Eval("activacionProducto") %>' /></div>   
                   
               
            </ItemTemplate>
            <SelectedItemStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        </asp:DataList>
        </div>
        </section>
    <!-- Footer -->
   


    <!-- Portfolio Modals -->
  
    

<%--    <!-- jQuery -->
    <script src="vendor/jquery/jquery.min.js"></script>

    <!-- Bootstrap Core JavaScript -->
    <script src="vendor/bootstrap/js/bootstrap.min.js"></script>

    <!-- Plugin JavaScript -->
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery-easing/1.3/jquery.easing.min.js"></script>

    <!-- Contact Form JavaScript -->
    <script src="js/jqBootstrapValidation.js"></script>
    <script src="js/contact_me.js"></script>

    <!-- Theme JavaScript -->
    <script src="js/freelancer.min.js"></script>--%>
</form>
</body>




</html>
