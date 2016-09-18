<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="vender.aspx.cs" Inherits="Mercado.vender" %>

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
        
            <div class="col-xs-1"></div>
    <div class="col-xs-10" style="background-color:white; border: solid 1px silver; border-radius: 5px; top: 0px; left: 0px; height: 324px; width:80%">
        
        <table style="width: 100%; margin-left:30px; height: 257px;">
            <tr>
                <td style="padding-top:30px; font-size:18px; color:gray; font-weight:normal" class="auto-style1" >Publicar un artículo</td>
                
                
            </tr>
            <tr>
                <td style="padding-top:20px;text-align:right; font-size:13px; color:gray; padding-bottom:20px">E-mail o usuario:</td>
                <td style="padding-left:10px" class="auto-style2"><asp:TextBox ID="TextBox1" CssClass="form-control" runat="server" Width="90%" Height="40px"></asp:TextBox></td>
                <td>¿Aún no tienes una cuenta?</td>
            </tr>
            <tr>
                <td style="padding-top:20px;text-align:right; font-size:13px; color:gray; padding-bottom:20px">Clave:</td>
                <td style="padding-left:10px" class="auto-style2"><asp:TextBox CssClass="form-control" ID="TextBox2" Width="90%" Height="40px" runat="server"></asp:TextBox></td>
                <td><asp:Button ID="Button2" runat="server" style="font-size:16px" CssClass="btn btn-primary" Height="37px" Text="Regístrate y publica" /></td>
            </tr>
            <tr>
                <td > </td>
                <td class="auto-style2">&nbsp;<asp:CheckBox ID="CheckBox1" runat="server" Font-Bold="false" />&nbsp;&nbsp;Mantenerme conectado </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Button ID="Button1" CssClass="btn btn-primary" Height="37px" runat="server" Text="Publicar" Font-Size="16px" style="margin-top:5px" Font-Bold="true" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>

       
        <hr style="color:silver" />
      
        <div style="font-size:13px; margin-top:-10px; z-index:999"><asp:LinkButton ID="LinkButton2" runat="server">No sé mi clave</asp:LinkButton></div>
  <div style="margin-left:100px"><asp:Image ID="Image1" style="vertical-align: middle;margin-top: -300px;margin-left: 390px;" ImageUrl="~/img/lineav.png" runat="server" /></div>
  
  


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
       
           <div class="col-xs-1"></div>

    <!-- Contact Section -->
   
        </section>
  

    

    <!-- Portfolio Modals -->
  
  
</form>
</body>

</html>

