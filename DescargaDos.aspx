<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DescargaDos.aspx.cs" Inherits="ReachSystem.DescargaDos" %>

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
        <br />
        <br />
        <br />
        <div class="baseform">
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True"  AutoGenerateColumns="False" GridLines="None"  DataSourceID="SqlDataSource1" CssClass="mGrid" PagerStyle-CssClass="pgr" AlternatingRowStyle-CssClass="alt" AllowSorting="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <Columns>                    
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                    <asp:BoundField DataField="Clase" HeaderText="Clase" SortExpression="Clase" />
                    <asp:BoundField DataField="Idioma" HeaderText="Idioma" SortExpression="Idioma" />
                    <asp:CommandField ShowSelectButton="True" SelectText="DESCARGAR" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:tarragoReachConnectionString %>" SelectCommand="SELECT [Nombre], [Clase], [Idioma] FROM [Productos] WHERE (([Idioma] = @Idioma) AND ([Clase] = @Clase))">
                <SelectParameters>
                    <asp:CookieParameter CookieName="paramunoC" Name="Idioma" Type="String" />
                    <asp:CookieParameter CookieName="paramdosC" Name="Clase" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
          </div>   
    </form>
</body>
</html>
