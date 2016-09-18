<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registrese.aspx.cs" Inherits="Mercado.registrese" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
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

    <!-- Publicidad -->

           
   
    <div class="container" >  
           
        


        <section style="padding: 100px">
        
            <div class="col-xs-1"></div>
    <div class="col-xs-10" style="background-color:white; border: solid 1px silver; border-radius: 5px; top: 0px; left: 0px; height: 550px;">

        <table style="width: 100%; margin-left:20px; height: 536px;">
            <tr>
                <td style="padding-top:20px; font-size:22px; color:black; font-weight:normal"  >Regístrate</td>
                
                
            </tr>
            <tr>
                <td style=" font-size:12px; color:gray; font-weight:normal"  ><div style="margin-top:-10px">* Datos obligatorios</div> </td>
                
                
            </tr>
            <tr>
                <td style="padding-top:20px;text-align:right; font-size:13px; color:gray; padding-bottom:20px" class="auto-style1">Usuario: *</td>
                <td style="padding-left:10px" class="auto-style2"><asp:TextBox ID="nickUsuario" MaxLength="10" CssClass="form-control" runat="server" Width="90%" Height="40px"></asp:TextBox></td>
                <td></td>
            </tr>            
            <tr>
                <td style="padding-top:20px;text-align:right; font-size:13px; color:gray; padding-bottom:20px" class="auto-style1">E-mail: </td>
                <td style="padding-left:10px" class="auto-style2"><asp:TextBox CssClass="form-control" ID="correoUsuario" Width="90%" Height="40px" runat="server"></asp:TextBox></td>
                <td></td>
            </tr>
            <tr>
                <td style="padding-top:20px;text-align:right; font-size:13px; color:gray; padding-bottom:20px" class="auto-style1">Repetir e-mail: </td>
                <td style="padding-left:10px" class="auto-style2"><asp:TextBox CssClass="form-control" ID="repetirCorreoUsuario" Width="90%" Height="40px" runat="server"></asp:TextBox></td>
                <td></td>
            </tr>
            <tr>
                <td style="padding-top:20px;text-align:right; font-size:13px; color:gray; padding-bottom:20px" class="auto-style1">Número de Celular: *</td>
                <td style="padding-left:10px" class="auto-style2"><asp:TextBox CssClass="form-control" ID="numeroCelular" Width="90%" Height="40px" runat="server"></asp:TextBox></td>
                <td><span style="margin-left:-50px" class="glyphicon glyphicon-phone" aria-hidden="true"></span></td>
            </tr>
             <tr>
                <td class="auto-style1"></td>
                <td style="text-align:left; font-size:10px; color:gray;" ><div style="    margin-top: -19px; margin-left: 10px;">Debe ser un móvil Ej.: (11) 4323-4556.</div></td>
                <td></td>
            </tr>
            <tr>
                <td style="padding-top:20px;text-align:right; font-size:13px; color:gray; padding-bottom:20px" class="auto-style1">Crear clave: * </td>
                <td style="padding-left:10px" class="auto-style2"><asp:TextBox CssClass="form-control" ID="claveUsuario" Width="70%" Height="40px" runat="server" MaxLength="10"></asp:TextBox></td>
                <td style="padding-top:20px;text-align:left; font-size:13px; color:gray; padding-bottom:12px"><div style="font-size:12px; color:gray; font-weight:normal; margin-left:-170px">Usa entre 6 y 10 caracteres</div></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Button ID="botonRegistrame" CssClass="btn btn-primary"  Height="37px" runat="server" Text="Registrarme" Font-Size="16px" style="margin-top:5px" Font-Bold="true" OnClick="botonRegistrame_Click" />
                </td>
                <td></td>
            </tr>
            <tr>
                <td></td>
                <td style="padding-top:10px; font-size:10px">Al registrarme, declaro que soy mayor de edad y acepto los <asp:LinkButton ID="LinkTerminos" runat="server" >Términos y condiciones</asp:LinkButton> y las <asp:LinkButton ID="LinkPoliticas" runat="server">Póliticas de privacidad</asp:LinkButton> de MercadoTop</td>
                <td></td>
            </tr>
        </table>

       
       


        <%--  --%>


</div>
   <div class="col-xs-1"></div>
        </section>
                

   </div> 

  

    <!-- Portfolio Modals -->
  
 
</form>
</body>

</html>

