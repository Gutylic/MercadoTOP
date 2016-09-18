<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Descripcion.aspx.cs" Inherits="Mercado.Descripcion" %>

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
        
            
    <div class="col-xs-12" style="background-color:white; border: solid 1px silver; border-radius: 5px; top: 0px; left: 0px; height: 924px; width:100%">

        <img src="img/producto.png" style="width:100%" />
    
       <%-- <div class="row grande" style=" width:106%; height:90%; margin-right:0px">--%>
        
            <div class ="well">

            <asp:TextBox ID="tituloProducto" class="form-control" Placeholder="Escriba un titulo para su producto" MaxLength="50" Width="100%" runat="server"></asp:TextBox>
</div>

            <div class="row">

<div class="col-xs-6">
            <div class="panel panel-default">
  <div class="panel-heading">Subir una foto <span style="color:grey; font-size:9px">(Foto Principal)</span></div>
  <div class="panel-body">
    <asp:FileUpload ID="foto1" runat="server" />
  </div>
</div>
         </div>   
            
            
     <div class="col-xs-6">
            <div class="panel panel-default">
  <div class="panel-heading">Subir una foto</div>
  <div class="panel-body">
    <asp:FileUpload ID="foto2" runat="server" />
  </div>
</div>          
                
                
        </div>

        <div class="col-xs-6">
            <div class="panel panel-default">
  <div class="panel-heading">Subir una foto</div>
  <div class="panel-body">
    <asp:FileUpload ID="foto3" runat="server" />
  </div>
</div>
       </div>     
           
            
     <div class="col-xs-6">
            <div class="panel panel-default">
  <div class="panel-heading">Subir una foto</div>
  <div class="panel-body">
    <asp:FileUpload ID="foto4" runat="server" />
  </div>
</div>          
               
                
        </div>    
</div>

            
            <div class="panel  panel-default">
  <div class="panel-heading">Escribir la dirección del vídeo de youtube <span style="color:grey; font-size:9px">(ej: www.youtube.com/w?wacth)</span>
   &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
       &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp; Precio <span style="color:grey; font-size:9px"> (ej: U$D 50) </span>&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
       &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
      Cantidad <span style="color:grey; font-size:9px">(ej: stock de productos)</span>
  </div>
  <div class="panel-body">
     <asp:TextBox ID="youtube"  class="form-control" Width="54%" runat="server"></asp:TextBox>
      <asp:TextBox ID="precio"  class="form-control" Width="20%" runat="server" style="margin-top:-34px; margin-left:500px"></asp:TextBox>
      <asp:TextBox ID="cantidad"  class="form-control" Width="20%" runat="server" style="margin-top:-34px; margin-left:700px"></asp:TextBox>
  </div>
     </div>






                <div class="well">
                    <ul class="nav nav-tabs">
  <li role="presentation" class="active"><a href="#">Descripción</a></li>
                        
</ul>
<asp:TextBox ID="descripcionProducto" Width="100%" BorderStyle="Ridge" TextMode="MultiLine" Rows="8"  runat="server"></asp:TextBox>
                </div>

     
<div class="col-xs-4 well " style="height: 78px;" >
        <label class="checkbox-inline" style=" margin-top: 10px;">
            <asp:CheckBox ID="checkNuevo" AutoPostBack="true" runat="server" Text="Nuevo" OnCheckedChanged="checkNuevo_CheckedChanged"/>
  
</label>
<label class="checkbox-inline" style=" margin-left: 130px; margin-top: 10px;" >
    <asp:CheckBox ID="checkUsuado" Checked ="true" AutoPostBack="true" runat="server" Text="Usado" OnCheckedChanged="checkUsuado_CheckedChanged"/>
 
</label>
</div>

 <div class="col-xs-1"></div>
        <div class="col-xs-7 well"> 
            <h5>Garantia:</h5>
            <asp:TextBox ID="garantia" CssClass="form-control" runat="server" Width="80%" style="margin-left: 70px; margin-top: -30px;" ></asp:TextBox>
        </div>


        <div class="row">
       
        <div class="col-xs-4"></div>
        <div class="col-xs-4" style="text-align:center">
            <asp:Button ID="botonPublicar" CssClass="btn btn-primary" Text="Publicar el producto" runat="server" OnClick="botonPublicar_Click"/>
            
        </div>
            <div class="col-xs-4">
           
                </div>
        

        </div>

     
                    
          </div>
        


     
        



           

  
   
        </section>
  
       </div>
    

  
    

  
</form>
</body>


</html>