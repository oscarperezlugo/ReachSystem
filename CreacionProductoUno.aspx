﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CreacionProductoUno.aspx.cs" Inherits="ReachSystem.CreacionProductoUno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="baseform">
        <p><h2>Crear Producto - PASO 1</h2></p>
            <div class="fila col10L">
                <input class="formulario" placeholder="Nombre del Producto" id="Nombre" type="text" required runat="server"/>            
            </div>            
            <div class="fila col10L">
                <asp:DropDownList ID="DropDownList4" runat="server" CssClass="formulario" required>
                    <asp:ListItem>CLASE</asp:ListItem>
                    <asp:ListItem>CLP</asp:ListItem>
                    <asp:ListItem>SPSP</asp:ListItem>
                    <asp:ListItem>CCCR</asp:ListItem>
                </asp:DropDownList>                
            </div>                                                     
            <div class="fila col10L">
                <asp:Button class="botonsubmit" value="REGISTRARME" type="submit"  runat="server" CssClass="botonsubmit"  OnClick="Unnamed1_Click"  Text="SIGUIENTE"/>            
            </div>
        </div>
            <br />
            <br />     
</asp:Content>
