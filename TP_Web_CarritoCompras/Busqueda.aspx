<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Busqueda.aspx.cs" Inherits="TP_Web_CarritoCompras.Busqueda" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

        <div class="container-busqueda">
            <% foreach (var item in listaFiltrada)
            {%>

                <div class="articulo">
                    <%--<img src="<%: item.ImagenUrl %>" alt="Alternate Text" />--%>
                    <p><%: item.Nombre %></p>
                    <p><%: item.Precio %></p>
                </div>
            <%} %>
            
            

        </div>
</asp:Content>
