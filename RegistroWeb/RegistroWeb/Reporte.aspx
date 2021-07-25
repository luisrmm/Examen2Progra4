<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reporte.aspx.cs" Inherits="RegistroWeb.Reporte" %>

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
            <label for="NumServicio">Numero de Servicio</label>
              <asp:TextBox ID="TxtNumServicio" runat="server"></asp:TextBox>
             <label for="Fecha">Fecha</label>
              <asp:TextBox ID="TxtFecha" runat="server"></asp:TextBox>
             <label for="HoraTrabajo">Horas Laboradas</label>
             <asp:TextBox ID="TxtHoraTra" runat="server"></asp:TextBox>
             <asp:Button ID="BtnRegistrar" runat="server" Text="Registrar" OnClick="BtnRegistrar_Click" />

            <asp:Label ID="lblDatos" runat="server"></asp:Label>

        </form>
    </div>

</body>
</html>
