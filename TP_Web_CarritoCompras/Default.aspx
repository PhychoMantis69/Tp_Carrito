﻿<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TP_Web_CarritoCompras._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="divBusqueda">
        <asp:TextBox class="txtBusqueda" ID="txtBusqueda" runat="server"></asp:TextBox>
        <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
    </div>

    <div class="container-busqueda">
        <% foreach (var item in listado)
        {%>

            <div class="articulo">
                <%--<img src="<%: item.ImagenUrl %>" alt="Alternate Text" />--%>
                <p><%: item.Nombre %></p>
                <p><%: item.Precio %></p>
            </div>
        <%} %>
    </div>
</asp:Content>
