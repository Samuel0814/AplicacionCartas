<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistroDestinatario.aspx.cs" Inherits="AplicacionCartas.Registros.RegistroDestinatario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <label for="TextBoxDestinatarioID">ID</label>
    <div class="form-row">
        <div class="form-group col-md-1">
            <asp:TextBox TextMode="Number" class="form-control" ID="TextBoxDestinatarioID" runat="server" placeholder="ID"></asp:TextBox>
        </div>
        <div class="btn-group-col-md-1">
            <asp:Button class="btn btn-primary" ID="ButtonBuscar" runat="server" Text="Buscar" OnClick="ButtonBuscar_Click" />
        </div>
    </div>
    <div class="row">
        <div class="form-group col-md-7 col-md-offset-3">
            <label for="TextBoxFecha">Fecha</label>
            <asp:TextBox TextMode="Date" class="form-control" ID="TextBoxFecha" runat="server" placeholder="Fecha"></asp:TextBox>
        </div>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="No puede dejar la fecha vacia" ForeColor="Red" Font-Bold="True" ControlToValidate="TextBoxFecha"></asp:RequiredFieldValidator>
        <div class="form-group col-md-7 col-md-offset-3">
            <label for="TextBoxNombre">Nombre</label>
            <asp:TextBox class="form-control" ID="TextBoxNombre" runat="server" placeholder="Nombre" autocomplete="off" ControlToValidate="TextBoxNombre"> </asp:TextBox>
            
        </div>
        <asp:RequiredFieldValidator ForeColor="red" ID="RequiredFieldValidator" runat="server" Display="Dynamic" ControlToValidate="TextBoxNombre" Font-Bold="True" ErrorMessage="No puede dejar el nombre vacio"></asp:RequiredFieldValidator>
        <div class="form-group col-md-7 col-md-offset-3">
            Cantidad de Cartas
            <asp:TextBox class="form-control" ID="TextBoxCantidadCartas" runat="server" placeholder="Cantidad Cartas" ReadOnly="True"></asp:TextBox>
        </div>
    </div>
    <div class="btn-block">
        <asp:Button class="btn btn-primary" ID="ButtonNuevo" runat="server" Text="Nuevo" OnClick="ButtonNuevo_Click" />
        <asp:Button class="btn btn-success" ID="ButtonGuardar" runat="server" Text="Guardar" OnClick="ButtonGuardar_Click" />
        <asp:Button class="btn btn-danger" ID="ButtonEliminar" runat="server" Text="Eliminar" OnClick="ButtonEliminar_Click" />
    </div>

</asp:Content>