<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ClienteServicio.aspx.vb" Inherits="WebClienteServicio.ClienteServicio" %>

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
                <label for="IDCliente">Cedula</label>
                <input type="number" id="IDCliente" name="Cedula" placeholder="Digite su cedula...">
                <asp:DropDownList ID="DplTipoServicio" runat="server">
                </asp:DropDownList>
                <asp:Button ID="BtnRegistrarServicio" runat="server" Text="Registrar" />
            </form>
        </div>

    </body>
</html> 
