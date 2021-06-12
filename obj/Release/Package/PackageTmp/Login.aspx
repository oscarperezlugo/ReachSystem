<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ReachSystem.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <meta name="Oscar Perez Lugo" content="Developer"/>
        <meta name="description"  content="Tarrago Brands"/>
        <meta name="keywords"  content="QUIMICOS"/>
        <meta name="viewport" content="width=device-width, initial-scale=1.0"/>        
        <title>Tarrago Reach System</title>
        <link href="favicon.ico" rel="shortcut icon" type="image/x-icon" />
        <link href="Content/columnas.css" rel="stylesheet" />
        <link href="Content/Site.css" rel="stylesheet" />
        <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"/>
</head>
<body>
    <form id="form1" runat="server">
         <nav class="nave fila col10L">
            <div class="col2L">
                <img id="logo" src="https://www.tarrago.com/wp-content/uploads/2019/07/logo-tarrago-web.png"/>
            </div>                       
        </nav>
        <div class="subnave"/>
        <div class="baseform">
            <br />
            <br />
            <br />
            <div class="texto">
            <h2><center><b>Welcome to the REACH System of Tarrago Brands International</b></center></h2><br />
               <center><h5>In this space you will find the necessary information for the registration, evaluation,</h5> </center>
               <center><h5>  authorization and restriction of the chemical preparations of our products.</h5> </center>
                
                <center><h5> We invite you to register on the platform to access the Safety Data Sheets. </h5></center> 
                </div>
            <p><h2>LOG IN</h2></p>
                
            <div class="fila col10L">
                <input class="formulario" placeholder="Email" id="Correo" type="email" required runat="server"/>            
            </div>                       
            <div class="fila col10L">
                <input class="formulario" placeholder="Password" id="Contrasena" type="password" required runat="server"/>            
            </div>            
            <p><a class="enlaces" href="Registro.aspx">Don’t you have an account? Register for an account</a></p>
            <p><a class="enlaces" href="Contrasena.aspx">Forgotten your password? Change Password</a></p>
            <div class="fila col10L">
                <asp:Button class="botonsubmit" value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmit" Text="LOG IN" OnClick="Unnamed1_Click" /></br>  
                </br>  
                <asp:Button class="botonsubmit" value="REGISTRARME" runat="server" CssClass="botonsubmit" Text="BACK TO TARRAGO WEBSITE" OnClick="Unnamed2_Click" UseSubmitBehavior="False" /><br />
            </div>
        </div>        
    </form>
</body>
</html>
