<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroServicio.aspx.cs" Inherits="WebRegistroServicio.RegistroServicio" %>

<!DOCTYPE html>
<html>
<style>
    input[type=text], select {
        width: 100%;
        padding: 12px 20px;
        margin: 8px 0;
        display: inline-block;
        border: 1px solid #ccc;
        border-radius: 4px;
        box-sizing: border-box;
    }

    input[type=number], select {
        width: 100%;
        padding: 12px 20px;
        margin: 8px 0;
        display: inline-block;
        border: 1px solid #ccc;
        border-radius: 4px;
        box-sizing: border-box;
    }

    input[type=tel], select {
        width: 100%;
        padding: 12px 20px;
        margin: 8px 0;
        display: inline-block;
        border: 1px solid #ccc;
        border-radius: 4px;
        box-sizing: border-box;
    }

    input[type=email], select {
        width: 100%;
        padding: 12px 20px;
        margin: 8px 0;
        display: inline-block;
        border: 1px solid #ccc;
        border-radius: 4px;
        box-sizing: border-box;
    }


    input[type=submit] {
        width: 100%;
        background-color: #50858b;
        color: white;
        padding: 14px 20px;
        margin: 8px 0;
        border: none;
        border-radius: 4px;
        cursor: pointer;
    }

        input[type=submit]:hover {
            background-color: #5497A7;
        }

    .cuerpo {
        border-radius: 5px;
        background-color: #f2f2f2;
        padding: 20px;
    }
</style>
<body>
    <h3>Registro Servicio</h3>

    <div class="cuerpo">
        <form id="form1" runat="server">
             <label for="IDCliente">Cedula<asp:Label ID="LblMensaje" runat="server"></asp:Label>
             </label>
     <asp:TextBox ID="TxtCedula" runat="server"></asp:TextBox>
            <label for="IDTipoServicio">Tipo Servicio</label>
             <asp:DropDownList ID="DDLTipServicio" runat="server">
                   <asp:ListItem Selected="True" Value="1"> Reparacion Telefono </asp:ListItem>
                  <asp:ListItem Value="2"> Reinstarlar S.O </asp:ListItem>
                  <asp:ListItem Value="3"> Reparar Computadora </asp:ListItem>
             </asp:DropDownList>
             <asp:Button ID="BtnRegistrar" runat="server" Text="Registrar" OnClick="BtnRegistrar_Click" />
              <label for="NombreTrabajador">Nombre del Trabajador</label>
             <asp:TextBox ID="TxtNombreTrabajador" runat="server" ReadOnly="True"></asp:TextBox>
              <label for="Precio">Tipo Precio</label>
             <asp:TextBox ID="TxtPrecio" runat="server" ReadOnly="True"></asp:TextBox>
              <label for="Fecha">Fecha</label>
             <asp:TextBox ID="TxtFecha" runat="server" ReadOnly="True"></asp:TextBox>

        </form>
    </div>

</body>
</html>
