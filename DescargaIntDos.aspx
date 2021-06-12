<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DescargaIntDos.aspx.cs" Inherits="ReachSystem.DescargaIntDos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
        <br />
        <br />
        <div class="baseform">
             <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">
                        <asp:Label ID="Label6" runat="server" Text="PRODUCT SEARCH RESULT" Style="font-weight: bold; font-size: 18px;"></asp:Label>
                    </div>
                </div>
            </div>
        <div class="card-body">
                <div class="form-row">
                    <asp:Label ID="Label1" runat="server" Style="font-weight: bold; font-size: 18px;"></asp:Label>
                    <%--<div class="col10L">--%>
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True"  AutoGenerateColumns="False" GridLines="None"  DataSourceID="SqlDataSource1" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black"  CssClass="mGrid table table-responsive table-striped" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" AllowSorting="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
<AlternatingRowStyle CssClass="alt"></AlternatingRowStyle>
                <Columns>                    
                    <asp:BoundField DataField="Nombre" HeaderText="NAME" SortExpression="Nombre" />
                    <%--<asp:BoundField DataField="Clase" HeaderText="Clase" SortExpression="Clase" />
                    <asp:BoundField DataField="Codigo" HeaderText="Codigo" SortExpression="Clase" />
                    <asp:BoundField DataField="Idioma" HeaderText="Idioma" SortExpression="Idioma" />--%>
                    <asp:CommandField ShowSelectButton="True" SelectText="DOWNLOAD" ButtonType="Button" />
                </Columns>
                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                            <HeaderStyle BackColor="white" Font-Bold="True" ForeColor="black" />
                            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                            <SelectedRowStyle BackColor="#CCCCCC" Font-Bold="True" ForeColor="White" />
                            <SortedAscendingCellStyle BackColor="#F7F7F7" />
                            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                            <SortedDescendingCellStyle BackColor="#E5E5E5" />
                            <SortedDescendingHeaderStyle BackColor="#242121" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:tarragoReachConnectionString %>" SelectCommand="SELECT Nombre, Clase, Codigo, Idioma FROM Productos WHERE (Idioma = @Idioma) AND (Clase = @Clase) AND (Nombre LIKE '%'+@Nombre+'%') OR (Idioma = @Idioma) AND (Clase = @Clase) AND (Codigo LIKE '%'+@Nombre+'%')">
                <SelectParameters>
                    <asp:CookieParameter CookieName="paramunoC" Name="Idioma" Type="String" />
                    <asp:CookieParameter CookieName="paramdosC" Name="Clase" Type="String" />
                    <asp:CookieParameter CookieName="paramtresC" Name="Nombre" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
          </div> 
             </div>
        </div>
        </div>
        </div>
        <div class="fila col10L">
               <center><asp:Button class="botonsubmit" value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmit" text="NEW SEARCH" OnClick="Unnamed1_Click" /></center>                               
            </div>
</asp:Content>
