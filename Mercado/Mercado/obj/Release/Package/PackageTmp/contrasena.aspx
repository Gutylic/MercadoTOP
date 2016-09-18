<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="contrasena.aspx.cs" Inherits="Mercado.contrasena" %>

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
       
     
        <div class="col-xs-2"></div> 
       
            <div class="col-xs-8" style="background-color:white; border: solid 1px silver; border-radius: 5px; top: 0px; left: 0px; height: 160px; width:60%">

        <table>
            <tr>
                <td style="padding-top:10px; font-size:18px; color:gray; font-weight:normal" class="auto-style1" >No sé mi clave</td>
                
                
            </tr>
            <tr style="text-align:right; font-size:13px; color:gray;">
            <td style="padding-bottom:10px"><div>Ingresa el usuario con el que te registraste y te ayudaremos</div></td>
            </tr>

        </table>
        <table style="width: 100%; margin-left:10px; height: 93px;">
            <tr>
                <td style="text-align:right; font-size:13px; color:gray;" class="auto-style3">Usuario:</td>
                <td style="padding-left:10px" class="auto-style4" ><asp:TextBox CssClass="form-control" ID="TextBox2" Width="30%" Height="30px" runat="server"></asp:TextBox></td>
              
            </tr>
            
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Button ID="Button1" CssClass="btn btn-primary" Height="37px" runat="server" Text="Continuar" Font-Size="16px" style="margin-top:5px" Font-Bold="true" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>

    </div>
        <div class="col-xs-2" ></div> 
     
   
    </section>
  
</div>
    

    <!-- Portfolio Modals -->
  
    

   
</form>
</body>
</html>
