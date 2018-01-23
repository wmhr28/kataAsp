<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="NashWebApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Algoritmo de Nash</h1>
        <p class="lead">El presente algoritmo resuelve los problemas de juegos bimatriciales de orden m,n (donde m son las filas y n las columnas), con 2 pagos basado en el m&eacute;todo de equlibrio de Nash en estrat&eacute;gias puras.</p>
        <p>
        <a href="http://miscelaneamatematica.org/Misc50/5003.pdf" target="_blank" class="btn btn-primary btn-lg">Leer m&aacute;s</a>
        <a href="https://www.youtube.com/watch?v=yjQ0j2cwYw8" target="_blank"  class="btn btn-primary btn-lg">Ver Video</a>

        </p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Problema del Prisionero</h2>
            
            <div ID="divResultPrisionero"  runat="server"></div>
            
        </div>
        <div class="col-md-4">
            <h2>Cadenas de TV</h2>
            <div ID="divResultCadenas"  runat="server"></div>
        </div>
        <div class="col-md-4">
            <h2>Matriz de 3x4</h2>
            <div ID="divResultMatriz"  runat="server"></div>
        </div>
    </div>

</asp:Content>
