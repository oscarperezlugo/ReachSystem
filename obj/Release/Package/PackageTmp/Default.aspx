<%@ Page Title="Tarrago Reach System" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ReachSystem._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">   
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" GridLines="None" AllowPaging="True" CssClass="mGrid" PagerStyle-CssClass="pgr" AlternatingRowStyle-CssClass="alt" AllowSorting="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
<AlternatingRowStyle CssClass="alt"></AlternatingRowStyle>
        <Columns>            
            <asp:BoundField DataField="Row" HeaderText="Row" InsertVisible="False" ReadOnly="True" SortExpression="Row" />
            <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
            <asp:BoundField DataField="Clase" HeaderText="Clase" SortExpression="Clase" />
            <asp:BoundField DataField="Idioma" HeaderText="Idioma" SortExpression="Idioma" />
            <asp:CommandField ShowSelectButton="True" SelectText="ACTUALIZAR" />
        </Columns>
<PagerStyle CssClass="pgr"></PagerStyle>
</asp:GridView>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:tarragoReachConnectionString %>" SelectCommand="SELECT [Row], [Nombre], [Clase], [Idioma], [Archivo] FROM [Productos]"></asp:SqlDataSource>
</asp:Content>
