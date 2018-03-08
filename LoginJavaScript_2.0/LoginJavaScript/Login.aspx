<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LoginJavaScript.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Esto es una pagina</title>
    <link href="css/bootstrap.css" rel="stylesheet" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <link href="Estilos.css" rel="stylesheet" />
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
<body style="background-color:#17a4cb">
<<form id="form1" runat="server">
    <div class="container">
        <div class="col-lg-4"></div>
        <div class="col-lg-4">
            <div class="jumbotron">
                
                <div class="container" style="margin-left:25px">
                    <img src="Candado.png"/>
                </div>
                <h3 class="text-center text-primary">LOGIN</h3>
                   
                <div class="form-group">
                    <input id="TextUser" type="text" class="form-control" placeholder="Ingrese Usuario" />
                    <!--PlaceHolder hace que en el interior del TextBox, aparezca un texto sombreado que desaparece
                        al hacer click-->
                </div>

                <div class="form-group">
                    <input id="TextPass" type="text" class="form-control" placeholder="Ingrese Contraseña" />
                </div>
                        
                <input id="Btn" type="button" value="Conectarse" class="btn btn-primary form-control" />

                <div id="div" class="visibilidad"></div>
                       
            </div>

         </div>
         <div class="col-lg-4"></div>
      
    </div>

</form>

    <script>
        $(document).ready(function (e) {

            $("#TextUser").focus(function (e) {
                $("#div").addClass("visibilidad");
            });

            $("#TextPass").focus(function (e) {
                $("#div").addClass("visibilidad");
            });

            $("#Btn").click(function (e) {
             
                var user = $("#TextUser").val();
                var pass = $("#TextPass").val();
                var texto, tipoTexto;

                if (user.length > 4 && pass.length > 9 && buscar_Mayus(user) && buscar_Mayus(pass)) {
                    texto = "Datos ingresados correctamente";
                    tipoTexto = "alert-success"; //Clase incuida en Bootstrap, da el color verde .  
                }
                else { 
                    texto = "Datos ingresados incorrectamente";
                    tipoTexto = "alert-danger"; //Clase incluida en Bootstrap, da el color rojo.
                }

                $("#div").removeClass("visibilidad").hide().html("<p class='alert " + tipoTexto + " text-center'>" + texto + "</p>").fadeIn(1000);
                /* Por defecto el div donde esta el mensaje, no esta visible, cuando se da click, se remueve la clase que le da esa propiedad,
                   Se usa hide(), para dar el efecto de FadeIn(), y se usa el metodo html para ingresar texto
                   Entre comillas dobles, en el interior, agrego comillas simples que simulan ser doble, para insertar una etiqueta que al
                   mismo tiempo contengan una clase.
                */
                $("#TextUser").val("");
                $("#TextPass").val("");
            });

        });
    </script>

</body>

</html>
