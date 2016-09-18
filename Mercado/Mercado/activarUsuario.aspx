tualizarProducto<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="activarUsuario.aspx.cs" Inherits="Mercado.activarUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

<title>MercadoTop</title>

   <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.0/jquery.min.js"></script>
    <!-- Latest compiled and minified CSS -->
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">
   <!-- Latest compiled and minified JavaScript -->
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>
    
    
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
        
            <div class="col-xs-4"></div>
    <div class="col-xs-4" style="background-color:white; border: solid 1px silver; border-radius: 5px; top: 0px; left: 0px; height:224px ;text-align: center;">
         
        <h4 style="padding-top:30px; font-size:18px; color:gray; font-weight:normal">Activar el usuario</h4>

        <asp:TextBox style="margin-top:20px ;   margin-left: 13px;" ID="celularUsuario" CssClass="form-control" runat="server" Width="90%" Height="40px"></asp:TextBox>
                
        <asp:Button ID="botonActivar" CssClass="btn btn-primary" Height="37px" runat="server" Text="Activar" Font-Size="16px" style="margin-top:25px" Width="80%" Font-Bold="true" OnClick="botonActivar_Click"  />
               
       
        
      
        
  
  
  


        <%--<div id="contenedor" >
 
          
 
            <div id="cuerpo">

                   <h5> Ingresar a Mi cuenta</h5>

                    <p><label >usuario:</label></p>
                        <input name="usuario" type="text" id="usuario"  autofocus="" required=""></p>
 
                    <p><label>Clave:</label></p>
                        <input name="contrasenia" type="password" id="contrasenia" /><asp:LinkButton ID="LinkButton1" runat="server">No sé mi clave</asp:LinkButton> </p>
 
                    <asp:CheckBox ID="CheckBox1" runat="server" /> Recordarme

                    <asp:Button ID="Button1" CssClass="btn btn-info" runat="server" Text="Ingresar" />
                
            </div><!--fin cuerpo-->
 
            <div id="pie">¿ún no tienes una cuenta?&nbsp;&nbsp;Registrate </div>
        </div><!-- fin contenedor -->--%>
   





    </div>
       
           <div class="col-xs-4"></div>

    <!-- Contact Section -->
   
        </section>
  

    

    <!-- Portfolio Modals -->

</form>
</body>

</html>