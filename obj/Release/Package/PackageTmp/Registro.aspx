<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="ReachSystem.Registro" %>

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
            <p><h2>Registro de Usuario</h2></p>
            <div class="fila col10L">
                <input class="formulario" placeholder="Nombre (Juan Perez)" id="Nombre" type="text" required runat="server"/>            
            </div>
            <div class="fila col10L">
                <input class="formulario" placeholder="Empresa (Tarrago Brands)" id="Apellido" type="text" required runat="server"/>            
            </div>
            <div class="fila col10L">
                <input class="formulario" placeholder="Email (juan@gmail.com)" id="Correo" type="email" required runat="server"/>            
            </div>
            <div class="fila col10L">
                <input class="formulario" placeholder="Télefono (555 555555)" id="Telefono" type="text" maxlength="11" required runat="server"/>            
            </div>
            <div class="fila col10L">
                <input class="formulario" placeholder="Dirección (Valencia, Calle Libra #55)" id="Dirección" type="text" required runat="server"/>            
            </div>
            <div class="fila col10L">
                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="formulario" required>
                    <asp:ListItem>IDIOMA</asp:ListItem>
                    <asp:ListItem>Bulgarian</asp:ListItem>
                    <asp:ListItem>Dansk</asp:ListItem>
                    <asp:ListItem>Eesti keel</asp:ListItem>
                    <asp:ListItem>English</asp:ListItem>
                    <asp:ListItem>Español</asp:ListItem>
                    <asp:ListItem>Français</asp:ListItem>
                    <asp:ListItem>Deutsch</asp:ListItem>
                    <asp:ListItem>Gaeilge</asp:ListItem>
                    <asp:ListItem>Greek</asp:ListItem>
                    <asp:ListItem>Hrvatski Jezik</asp:ListItem>
                    <asp:ListItem>Italiano</asp:ListItem>
                    <asp:ListItem>Latviešu</asp:ListItem>
                    <asp:ListItem>Lietuvių</asp:ListItem>
                    <asp:ListItem>Magyar</asp:ListItem>
                    <asp:ListItem>Malti</asp:ListItem>
                    <asp:ListItem>Nederlands</asp:ListItem>
                    <asp:ListItem>Norsk</asp:ListItem>
                    <asp:ListItem>Polski</asp:ListItem>
                    <asp:ListItem>Português</asp:ListItem>
                    <asp:ListItem>Română</asp:ListItem>
                    <asp:ListItem>Russian</asp:ListItem>
                    <asp:ListItem>Slovenčina</asp:ListItem>
                    <asp:ListItem>Slovenščina</asp:ListItem>
                    <asp:ListItem>Suomi</asp:ListItem>
                    <asp:ListItem>Svenska</asp:ListItem>
                    <asp:ListItem>Türkçe</asp:ListItem>
                    <asp:ListItem>Čeština</asp:ListItem>
                </asp:DropDownList>                
            </div>
            <div class="fila col10L">
                <asp:DropDownList ID="DropDownList2" runat="server" CssClass="formulario" required>
                    <asp:ListItem>PAIS</asp:ListItem>
                    <asp:ListItem>ALEMANIA</asp:ListItem>
                    <asp:ListItem>AUSTRIA</asp:ListItem>
                    <asp:ListItem>BÉLGICA</asp:ListItem>
                    <asp:ListItem>BULGARIA</asp:ListItem>
                    <asp:ListItem>CHIPRE</asp:ListItem>
                    <asp:ListItem>CROACIA</asp:ListItem>
                    <asp:ListItem>DINAMARCA</asp:ListItem>
                    <asp:ListItem>ESLOVENIA</asp:ListItem>
                    <asp:ListItem>ESPAÑA</asp:ListItem>
                    <asp:ListItem>ESTONIA</asp:ListItem>
                    <asp:ListItem>FINLANDIA</asp:ListItem>
                    <asp:ListItem>FRANCIA</asp:ListItem>
                    <asp:ListItem>GRECIA</asp:ListItem>
                    <asp:ListItem>HUNGRÍA</asp:ListItem>
                    <asp:ListItem>IRLANDA</asp:ListItem>
                    <asp:ListItem>ITALIA</asp:ListItem>
                    <asp:ListItem>LETONIA</asp:ListItem>
                    <asp:ListItem>LITUANIA</asp:ListItem>
                    <asp:ListItem>LUXEMBURGO</asp:ListItem>
                    <asp:ListItem>MALTA</asp:ListItem>
                    <asp:ListItem>PAÍSES BAJOS</asp:ListItem>
                    <asp:ListItem>POLONIA</asp:ListItem>
                    <asp:ListItem>PORTUGAL</asp:ListItem>
                    <asp:ListItem>REPÚBLICA CHECA</asp:ListItem>
                    <asp:ListItem>REPÚBLICA ESLOVACA</asp:ListItem>
                    <asp:ListItem>RUMANÍA</asp:ListItem>
                    <asp:ListItem>SUECIA</asp:ListItem>                    
                </asp:DropDownList>                
            </div>
            <div class="fila col10L">
                <asp:DropDownList ID="DropDownList3" runat="server" CssClass="formulario" required>
                    <asp:ListItem>IDIOMA DE ORIGEN</asp:ListItem>
                    <asp:ListItem>Bulgarian</asp:ListItem>
                    <asp:ListItem>Dansk</asp:ListItem>
                    <asp:ListItem>Eesti keel</asp:ListItem>
                    <asp:ListItem>English</asp:ListItem>
                    <asp:ListItem>Español</asp:ListItem>
                    <asp:ListItem>Français</asp:ListItem>
                    <asp:ListItem>Deutsch</asp:ListItem>
                    <asp:ListItem>Gaeilge</asp:ListItem>
                    <asp:ListItem>Greek</asp:ListItem>
                    <asp:ListItem>Hrvatski Jezik</asp:ListItem>
                    <asp:ListItem>Italiano</asp:ListItem>
                    <asp:ListItem>Latviešu</asp:ListItem>
                    <asp:ListItem>Lietuvių</asp:ListItem>
                    <asp:ListItem>Magyar</asp:ListItem>
                    <asp:ListItem>Malti</asp:ListItem>
                    <asp:ListItem>Nederlands</asp:ListItem>
                    <asp:ListItem>Norsk</asp:ListItem>
                    <asp:ListItem>Polski</asp:ListItem>
                    <asp:ListItem>Português</asp:ListItem>
                    <asp:ListItem>Română</asp:ListItem>
                    <asp:ListItem>Russian</asp:ListItem>
                    <asp:ListItem>Slovenčina</asp:ListItem>
                    <asp:ListItem>Slovenščina</asp:ListItem>
                    <asp:ListItem>Suomi</asp:ListItem>
                    <asp:ListItem>Svenska</asp:ListItem>
                    <asp:ListItem>Türkçe</asp:ListItem>
                    <asp:ListItem>Čeština</asp:ListItem>
                </asp:DropDownList>                
            </div>
            <div class="fila col10L">
                <input class="formulario" placeholder="Empresa De Origen(Tarrago Brands)" id="Text1" type="text" required runat="server"/>            
            </div>
            <div class="fila col10L">
                <input class="formulario" placeholder="Contraseña" id="Contraseña" type="password" required runat="server"/>            
            </div>
            <div class="fila col10L">
                <input class="formulario" placeholder="Repetir Contraseña" id="Repetir" type="password" required runat="server"/>            
            </div>            
            <p><a class="enlaces" href="Login.aspx">¿Ya Tienes una Cuenta? Inicia Sesión desde Aquí</a></p>
            <div class="fila col10L">
                <asp:Button class="botonsubmit" value="REGISTRARME" type="submit"  runat="server" CssClass="botonsubmit"  OnClick="Unnamed1_Click"  Text="REGISTRARME"/>            
            </div>
            <br />
            <br />
        </div>        
    </form>
</body>
</html>
