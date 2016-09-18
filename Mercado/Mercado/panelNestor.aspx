<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="panelNestor.aspx.cs" Inherits="Mercado.panelNestor" EnableEventValidation="false" %>

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
    <form id="form1" runat="server">
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


    <div class="col-xs-3"></div>
    <div class="col-xs-6">
        <div class="row well" style="margin-top: 154px">

            <h3 style="
    text-align: center;
    margin-top: :-10px;
    margin-top: 0px;
    margin-bottom: 20px;
">Ingresar como administrador</h3>

        <form class="form-horizontal">
  <div class="form-group" style="margin-top:10px; padding-bottom: 30px; ">
    <label for="inputEmail13" class="col-sm-3 control-label" style="padding-top: 8px;">Administrador</label>
    <div class="col-sm-9">
      
        <asp:TextBox ID="nickAdministrador" runat="server" placeholder="Ingrese su Administrador" CssClass="form-control"></asp:TextBox>
    </div>
  </div>

  
  <div class="form-group" style="margin-top:10px">

    <div class="col-sm-6" style="text-align: center;">

        <asp:Button ID="botonCrearAdministrador" runat="server" Text="Crear Administrador" class="btn btn-primary" OnClick="botonCrearAdministrador_Click" />

    </div>

    <div class="col-sm-6" style="text-align: center;">

        <asp:Button ID="botonBorrarAdministrador" runat="server" Text="Borrar Administrador" class="btn btn-primary" OnClick="botonBorrarAdministrador_Click" />

    </div>

      <hr />

<div class="col-sm-12" style="text-align: center; margin-top: 50px">
        <asp:Button ID="mostrarProductos" runat="server" CssClass="btn btn-primary" Text="Listado de Productos" Width="50%" OnClick="mostrarProductos_Click"/>
       </div>

  </div>
</form>
    </div>
        </div>

    <div class="col-xs-3"></div>

    </div>


    </form>
</body>


</html>
