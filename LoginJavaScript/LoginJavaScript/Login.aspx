﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LoginJavaScript.Login" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <meta content="text/html; charset=utf-8" http-equiv="Content-Type"/>
        <title>
            XXX Page Just Sarcasm
        </title>
        <link rel="stylesheet" href="estilos.css" type="text/css"/>
            <meta name="viewport" content="width=device-width, user-scalable=no, initial-scale=1.0, maximun-scale=1.0, minimun-scale=1.0" />
                ﻿
                <script src="js/jquery-3.3.1.min.js"> </script>
                <script>
                    function buscar_Mayus(cadena) {
                        var flag = false;
                        var cont = 0;
                        var size = cadena.length;
                        while (cont < size && flag == false) {
                            if (cadena[cont] >= 'A' && cadena[cont] <= 'Z')
                                flag = true;
                            cont++;
                        }
                        return flag;
                    }
                </script>
    </head>
    <body style="height: 158px; width: 940px;">
        <div class="contenedor">
            <header>
                <h1>
                    Applying Responsive Design
                </h1>
            </header>
            <section class="main">
            <form id="form1" runat="server" typeof="">
                <div id="div1">
                    <h4>
                        Ingrese sus datos:
                    </h4>
                    <p style="margin-left: 320px">
                        Usuario:
                        <input id="TextUser" type="text"/>
                    </p>
                    <p style="margin-left: 300px">
                        Contraseña:
                        <input id="TextPass" type="text"/>
                    </p>
                    <p style="margin-left: 400px">
                        <input id="Btn" type="button" value="Login"/>
                    </p>
                </div>
                
            </form>
            </section>
            <script>
                $(document).ready(function (e) {
                    $("#TextUser").offset({ top: 60, left: ($("#div1").width() / 2 - $("#TextUser").width() / 2) });
                    $("#TextPass").offset({ top: 95, left: ($("#div1").width() / 2 - $("#TextPass").width() / 2) });
                    $("#Btn").offset({ top: 150, left: ($("#div1").width() / 2 - $("#Btn").width() / 2) })
                        .click(function (e) {
                            var user = $("#TextUser").val();
                            var pass = $("#TextPass").val();
                            $("#TextUser").val("");
                            $("#TextPass").val("");
                            if (user.length > 4 && pass.length > 9 && buscar_Mayus(user) == true && buscar_Mayus(pass) == true)
                                alert("Los datos han sido ingresado correctamente");
                            else
                                alert("Error en el ingreso de los datos, vuelva a intentarlo");
                        });
                });
            </script>
        </div>
    </body>
</html>