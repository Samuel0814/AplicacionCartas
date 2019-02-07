<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ConsultaCartas.aspx.cs" Inherits="AplicacionCartas.Consultas.ConsultaCartas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

      <div class="row justify-content-center">
        <div class="col-lg-4">
            <asp:Label ID="FiltroLabel" runat="server" Text="Filtrar-por">
                        Filtro:
            </asp:Label>
            <asp:DropDownList ID="FiltroDropDownList" CssClass="form-control" runat="server">
                <asp:ListItem></asp:ListItem>
                <asp:ListItem>CartaID</asp:ListItem>
                <asp:ListItem>DestinatarioID</asp:ListItem>
                <asp:ListItem>Fecha</asp:ListItem>
                <asp:ListItem>Cuerpo</asp:ListItem>
                <asp:ListItem>Cantidad</asp:ListItem>
            </asp:DropDownList>
        </div>
        <div class="col-lg-1"></div>
        <div class="col-lg-4">
            <asp:Label ID="BuscarLabel" runat="server" Text="Buscar">Buscar:</asp:Label>
            <asp:TextBox ID="BuscarTextBox" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
        <div class="col-lg-1 p-0">
            <asp:LinkButton ID="BuscarLinkButton" CssClass="btn btn-secondary mt-4" runat="server" OnClick="BuscarLinkButton_Click">
                        <span class="fas fa-search"></span>
                        Buscar
            </asp:LinkButton>
        </div>
    </div>

    <div class="row justify-content-center mt-3">
        <div class="col-lg-11">
            <asp:GridView ID="CartasGridView" runat="server" AllowPaging="true" PageSize="7" CssClass="table table-striped table-hover table-responsive-lg">
               
            </asp:GridView>
        </div>
    </div>

</asp:Content>
