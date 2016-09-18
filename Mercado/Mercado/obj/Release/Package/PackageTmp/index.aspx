<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Mercado.index" %>

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
    
     <style>

        
    </style>

</head>

<body id="page-top">
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
                    <td style="width:30%; padding-left:90px; color:black"><asp:LinkButton style="color:black"   ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Regístrate&nbsp;</asp:LinkButton>
                    |
                    <asp:LinkButton ID="LinkButton2" runat="server" style="color:black" OnClick="LinkButton2_Click">&nbsp;Ingresa&nbsp;</asp:LinkButton>
                    |
                    <asp:LinkButton ID="LinkButton3" runat="server" style="color:black" OnClick="LinkButton3_Click">&nbsp;Vender</asp:LinkButton></td>
                    
                </tr>
               
            </table>
</div>
        

        
    
    </header>

    <!-- Publicidad -->
    <section>
        
            <div class="row" style="margin-left:0px; margin-right:0px;">
                              
            
<div id="carousel-example-generic" class="carousel slide" data-ride="carousel">
  <!-- Indicators -->
  <ol class="carousel-indicators">
    <li data-target="#carousel-example-generic" data-slide-to="0" class="active"></li>
    <li data-target="#carousel-example-generic" data-slide-to="1"></li>
    <li data-target="#carousel-example-generic" data-slide-to="2"></li>
  </ol>

  <!-- Wrapper for slides -->
  <div class="carousel-inner" role="listbox" style="margin-top:54px">
    <div class="item active">
      <img src="img/foto1.jpg" style="height:350px">
      
    </div>
    <div class="item">
      <img src="img/foto1.jpg" style="height:350px">
      
    </div>
      <div class="item">
      <img src="img/foto1.jpg" style="height:350px">
      
    </div>
    
  </div>

  <!-- Controls -->
  <a class="left carousel-control" href="#carousel-example-generic" role="button" data-slide="prev">
    <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
    <span class="sr-only">Previous</span>
  </a>
  <a class="right carousel-control" href="#carousel-example-generic" role="button" data-slide="next">
    <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
    <span class="sr-only">Next</span>
  </a>
</div>
    
<div class="container">
    
                    <%--<img alt="" src="img/foto1.jpg" style="padding-top: 54px;"/>--%>
                </div>
            </div>


<!-- Publicidad Pago -->

    

    
    <!-- About Section -->
    
        <div class="row" style="margin-left:0px; margin-right:0px; background-color: #FFFFFF;border-bottom: 1px solid #e0e0e0;height: 54px">
                <div class="col-xs-12">                    
                    
                </div>
            </div>
            
            <div class="row" style="margin-left:0px; margin-right:0px; width:100%">
                <div class="col-lg-12" style="background-color:#e8e7e7; height:900px;">
                    
                </div>
            </div>
        

    <!-- Contact Section -->
   
        </section>
    <!-- Footer -->
   
    </div>

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

