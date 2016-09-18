<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="actualizarProducto.aspx.cs" Inherits="Mercado.actualizarProducto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
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
    <form id="form1" runat="server">
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
                       
                  <a href="#" data-toggle="popover" id="todo" data-placement="bottom" runat="server" data-content="<a href='panelUsuario.aspx'>Panel de Ventas </a>"> <asp:Label ID="etiquetaNombre" runat="server" style="color:black" Text="Label"></asp:Label>

                  </a>
                        
                        
                     
             
                     
                    |                    
                    <asp:LinkButton ID="LinkVender" runat="server" style="color:black" >&nbsp;Vender</asp:LinkButton>
                    |
                    <asp:LinkButton ID="LinkButton1" runat="server" style="color:black" >&nbsp;Cerrar Session</asp:LinkButton>
                    </td>
                    
                </tr>
               
            </table>

    </div>        

        
    
    </header>
        
        
        <div class="container">
        
            <div class="row" style="margin-top:90px">
                <div class ="col-xs-2 Imagen1 well" style="text-align:center" ><asp:Image ID="Image1"  style=" width: 120px; height: 120px;" ImageUrl="" runat="server" /></div>
                <div class="col-xs-10">
                    <div class="panel panel-default">
                        <div class="panel-heading" style="font-size:24px; color:gray">Titulo del Producto</div>
                            <div class="panel-body">
                                <asp:TextBox ID="tituloProducto" Height="40px" runat="server" CssClass="form-control form" Style=" width: 100%;  "></asp:TextBox></div> 
                            </div>
                        </div>
               </div>

            <div class="row">
                <div class ="col-xs-2 Imagen2 well " style="text-align:center; height: 160px;" ><asp:Image ID="Image2"   style=" width: 120px; height: 120px;"  ImageUrl="" runat="server" /></div>
                <div class="col-xs-10" style="margin-top:-35px">
                     <div class="panel panel-default">
                        <div class="panel-heading" style="font-size:24px; color:gray">Descripción</div>
                            <div class="panel-body">
                                 <asp:TextBox ID="descripcionProducto" CssClass="form-control form" TextMode="MultiLine" Rows="6" Style="width: 100%;" runat="server"></asp:TextBox></div>
                            </div>
                        </div>
                    
                    
                    
                    
            </div>

            <div class="row">
                <div class ="col-xs-2 Imagen3 well " style="text-align:center; height: 160px; margin-top:-25px " ><asp:Image ID="Image3" style=" width: 120px; height: 120px;" ImageUrl="" runat="server" /></div>                
                <div class="col-xs-3 ">
                    <div class="panel panel-default">
                        <div class="panel-heading">Cantidad</div>
                        <div class="panel-body">
                            <asp:TextBox ID="cantidadProducto" CssClass="form-control form" runat="server" Style="width: 100%;"></asp:TextBox>
                        </div>
                    </div>
                </div>
                 <div class ="col-xs-3">
                     <div class="panel panel-default">
                        <div class="panel-heading">Precio</div>
                        <div class="panel-body">
                            <asp:TextBox ID="precioProducto" CssClass="form-control form" runat="server" Style="width: 100%;"></asp:TextBox>
                        </div>
                    </div>
                </div>

                     
                <div class="col-xs-4 ">
                    <div class="panel panel-default">
                        <div class="panel-heading">Garantia</div>
                        <div class="panel-body">
                            <asp:TextBox ID="garantiaProducto" CssClass="form-control form" runat="server" Style="width: 100%;"></asp:TextBox>
                        </div>
                    </div>
                
                    
                </div>
              </div>      
                    
            

            <div class="row">
                <div class ="col-xs-2 Imagen4 well " style="text-align:center; height: 160px;"><asp:Image ID="Image4" style=" width: 120px; height: 120px;" ImageUrl="" runat="server" /></div>
                <div class="col-xs-6 " style="margin-top:-28px">
                    <div class="panel panel-default">
  <div class="panel-heading">Vídeo <span style="color:gray; font-size:10px">youtube</span></div>
  <div class="panel-body">
     <asp:TextBox ID="youtube" CssClass="form-control form" runat="server" Style="width: 100%; "></asp:TextBox></div>
  </div>
</div>

                    
                    
                   
                 <div class ="col-xs-4" style="margin-top:-28px">
                     
                     <div class="panel panel-default">
                         <div class="panel-heading">Estado del producto</div>
                         <div class="panel-body" style="height:63px">
                             <label class="checkbox-inline" style="margin-left: 70px;margin-top: 7px;  ">
                                 <asp:CheckBox ID="CheckBoxNuevo" runat="server" />Nuevo</label>
                                 
                             <label class="checkbox-inline" style="margin-left: 40px;margin-top: 7px;   ">
                                 <asp:CheckBox ID="CheckBoxUsado" runat="server" />Usado
                                 </label>
                         </div>
                     </div>
                     
                     
                    
            </div>

        <div class="col-xs-12"><asp:Button ID="botonActivacion" style="width: 80%; margin-left: 210px;margin-top: -120px;" class="btn btn-primary" runat="server" Text="Activación" OnClick="botonActivacion_Click"/></div>
        
    </div>

            
    </form>
</body>
</html>
