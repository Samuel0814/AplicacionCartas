<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistroCartas.aspx.cs" Inherits="AplicacionCartas.Registros.RegistroCartas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <label for="TextBoxCartasID">ID</label>
    <div class="form-row">
        <div class="form-group col-md-1">
            <asp:TextBox TextMode="Number" class="form-control" ID="TextBoxCartasID" runat="server" placeholder="ID"></asp:TextBox>
        </div>
        <div class="btn-group col-md-1">
            <asp:Button class="btn btn-primary" ID="ButtonBuscar" runat="server" Text="Buscar" OnClick="ButtonBuscar_Click" />
        </div>
    </div>
    
    <label for="DestinatarioDropDownList">Destinatario</label>
    <div class="row">
        <div class="form-group col-md-7"">
            <div class="form-group col-md-7">
                <asp:DropDownList ID="DestinatarioDropDownList" CssClass="form-control" runat="server">
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>
        <asp:RequiredFieldValidator ForeColor="red" ID="RequiredFieldValidator" runat="server" Display="Dynamic" ControlToValidate="DestinatarioDropDownList" Font-Bold="True" ErrorMessage="No puede dejar el destinatario vacio"></asp:RequiredFieldValidator>
        <div class="form-group col-md-7">
            <label for="TextBoxFecha">Fecha</label>
            <asp:TextBox TextMode="Date" class="form-control" ID="TextBoxFecha" runat="server" placeholder="Fecha"></asp:TextBox>
        </div>
        <asp:RequiredFieldValidator ForeColor="red" ID="RequiredFieldValidator1" runat="server" Display="Dynamic" ControlToValidate="TextBoxFecha" Font-Bold="True" ErrorMessage="No puede dejar la fecha vacia"></asp:RequiredFieldValidator>
        <div class="form-group col-md-7">
            Cuerpo
            <asp:TextBox TextMode="MultiLine" class="form-control" ID="TextBoxCuerpo" runat="server" placeholder="Cuerpo"></asp:TextBox>
        </div>
        <asp:RequiredFieldValidator ForeColor="red" ID="RequiredFieldValidator2" runat="server" Display="Dynamic" ControlToValidate="TextBoxCuerpo" Font-Bold="True" ErrorMessage="No puede dejar el cuerpo vacio"></asp:RequiredFieldValidator>
        <div class="form-group col-md-7">
            Cantidad
            <asp:TextBox TextMode="Number" class="form-control" ID="TextBoxCantidad" runat="server" placeholder="Cantidad"></asp:TextBox>
        </div>
    </div>

    <asp:Button class="btn btn-primary" ID="ButtonNuevo" runat="server" Text="Nuevo" OnClick="ButtonNuevo_Click" />
    <asp:Button class="btn btn-success" ID="ButtonGuardar" runat="server" Text="Guardar" OnClick="ButtonGuardar_Click" />
    <asp:Button class="btn btn-danger" ID="ButtonEliminar" runat="server" Text="Eliminar" OnClick="ButtonEliminar_Click" />
</asp:Content>