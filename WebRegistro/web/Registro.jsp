<!DOCTYPE html>
<html>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <style>
        body {margin:0;}

        .icon-bar {
            width: 100%;
            background-color: #555;
            overflow: auto;
        }

        .icon-bar a {
            float: left;
            width: 20%;
            text-align: center;
            padding: 12px 0;
            transition: all 0.3s ease;
            color: white;
            font-size: 36px;
        }

        .icon-bar a:hover {
            background-color: #000;
        }

        .active {
            background-color: #5497A7;
        }

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

        <div class="icon-bar">
            <a class="active" href="index.html"><i class="fa fa-home"></i></a> 
        </div>

        <h3>Registro Cliente</h3>

        <div class="cuerpo">
            <form method="post" action="RecuperacionUsuario">
                <label for="IDCliente">Cedula</label>
                <input type="number" id="IDCliente" name="Cedula" placeholder="Digite su cedula...">

                <label for="Nombre">Nombre</label>
                <input type="text" id="Nombre" name="Nombre" placeholder="Digite su nombre...">

                <label for="Telefono">Telefono</label>
                <input type="tel" id="Telefono" name="Telefono" placeholder="Digite su telefono...">

                <label for="Correo">Correo</label>
                <input type="email" id="Correo" name="Correo" placeholder="Digite su correo...">

                <input type="submit" value="Registrar">
            </form>
        </div>

    </body>
</html> 
