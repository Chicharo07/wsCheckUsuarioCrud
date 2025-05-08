<%@ Page Async="true" Title="" Language="C#" MasterPageFile="~/mpPrincipal.Master" AutoEventWireup="true" CodeBehind="Formulario web1.aspx.cs" Inherits="wsCheckUsuario.Formulario_web1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="file:///c:\users\gg533\source\repos\wscheckusuario\wscheckusuario\app_themes\principal\principal.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <asp:Label ID="Label1" runat="server" Text="Reporte de usuarios registrados" CssClass="tituloContenido"></asp:Label>

    <br />
    <br />
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/imagenes/icon_logalum.GIF" OnClick="ImageButton1_Click" />
    <br />
    <br />
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" PageSize="5" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        <AlternatingRowStyle BackColor="#66FFFF" ForeColor="Black" />
        <HeaderStyle BackColor="#000099" Font-Bold="True" Font-Names="Arial" Font-Size="Medium" ForeColor="White" />
        <PagerStyle BackColor="#0000CC" Font-Bold="True" Font-Names="Arial" Font-Size="Medium" ForeColor="White" />
        <RowStyle BackColor="#99CCFF" Font-Names="Arial" Font-Size="Small" ForeColor="Black" />
    </asp:GridView>
</asp:Content>