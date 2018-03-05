<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Curso3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<%--    <link href="css/bootstrap-grid.min.css" rel="stylesheet" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />--%>
    <script src="js/jquery-3.3.1.min.js"></script>
    <title></title>
    <style type="text/css">
        #form1 {
            height: 220px;
        }
    </style>
</head>
<body>
    <h2>BRIAN MOVE LA CARPETA</h2>
    <form id="form1" runat="server" class="text-center">
        <div id="div1">
            <br />
            Username:
          <input id="txtUser" type="text"/><br />
            Password:
          <input id="txtPassword" type="text" /><br />
          <input id="btnLogin" type="button" value="Ingresar" <%--mio="Hola"--%>/></div>
        
    </form>
<!--
    Ready ejecuta una funcion
    jquery se trabaja con funciones

-->
<script type="text/javascript">
    $(document).ready(function (e) {
        $("#btnLogin").removeAttr("disabled")
            .click(function (e) {

            });
        var user = $("#txtUser").val();
        if (user.length < 4) {

        }
        //$("#btnLogin").attr("mio", "");
        //alert($("#btnLogin").attr("mio"));


    });
</script>

</body>
</html>
