<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LoginJavaScript.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Esto es una pagina</title>
    <script src="js/jquery-3.3.1.min.js"></script>

    <script>
        function buscar_Mayus(cadena){
            var flag = false;
            var cont = 0;
            var size = cadena.length;

            while(cont < size && flag == false){
                if (cadena[cont] >= 'A' && cadena[cont] <= 'Z')
                    flag = true;
                cont++;
            }
            return flag;
        }
    </script>

</head>

<body style="height: 158px; width: 940px;">
    <form id="form1" runat="server">
    <div id="div1">
        <h4>Ingrese sus datos:</h4>
        <p style="margin-left: 320px"> Usuario:</p>
        <p style="margin-left: 300px"> Contraseña:</p>
        <input id="Btn" type="button" value="Login" />
        <input id="TextUser" type="text" />
        <input id="TextPass" type="text" />    
    </div>
    </form>

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
</body>
</html>
