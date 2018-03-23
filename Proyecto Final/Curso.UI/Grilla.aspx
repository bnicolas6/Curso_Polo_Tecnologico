<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Grilla.aspx.cs" Inherits="Curso.UI.Grilla" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="icon" href="img/favicon.png" type="image/png" />
    <link rel="shortcut icon" href="img/favicon.ico" type="img/x-icon" />

    <link href="css/bootstrap.css" rel="stylesheet" type="text/css" />
    <link href="css/grilla.css?V=4" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="js/jquery-3.3.1.min.js"></script>
    <script type="text/javascript" src="js/bootstrap.js"></script>
    <script type="text/javascript" src="js/fontawesome-all.js"></script>
    <script type="text/javascript" src="js/GyL.Utils.js"></script>
</head>
<body>
    <form id="formMain" runat="server">
    </form>
    <script type="text/javascript">
        $(document).ready(function (e) {
            var _tools = GyL.Utils.Tools;
            _tools.ajax('Services/WebService1.asmx/GetData', null, function (msg) {
                var oResult = JSON.parse(msg.d);
                var html = "<div class='container container-table'>";
                html += "<div class='row row-header'>";
                html += "<div class='col col-sm-4'>Nombre</div>";
                html += "<div class='col col-sm-4'>Apellido</div>";
                html += "<div class='col col-sm-4'>Teléfono</div></div>";
                $.each(oResult, function (i, item) {
                    if (i % 2 == 0)
                        html += "<div class='row row-pair'>";
                    else
                        html += "<div class='row row-odd'>";
                    html += "<div class='col col-sm-4'>" + item.Name + "</div>";
                    html += "<div class='col col-sm-4'>" + item.Surname + "</div>";
                    html += "<div class='col col-sm-4'>" + item.Phone + "</div></div>";
                });
                html += "</div>";
                $('#formMain').html(html);
                $('.container-table .row:last').addClass('row-last');
                $('.container-table .row:last .col:last').addClass('col-last');
            });
            //$.ajax({
            //    type: 'POST',
            //    url: 'Services/WebService1.asmx/GetData',
            //    contentType: "application/json;charset=utf-8",
            //    dataType: "json",
            //    success: function (msg) {
            //        var oResult = JSON.parse(msg.d);
            //        var html = "<div class='container container-table'>";
            //        html += "<div class='row row-header'>";
            //        html += "<div class='col col-sm-4'>Nombre</div>";
            //        html += "<div class='col col-sm-4'>Apellido</div>";
            //        html += "<div class='col col-sm-4'>Teléfono</div></div>";
            //        $.each(oResult, function (i, item) {
            //            if (i % 2 == 0)
            //                html += "<div class='row row-pair'>";
            //            else
            //                html += "<div class='row row-odd'>";
            //            html += "<div class='col col-sm-4'>" + item.Name + "</div>";
            //            html += "<div class='col col-sm-4'>" + item.Surname + "</div>";
            //            html += "<div class='col col-sm-4'>" + item.Phone + "</div></div>";
            //        });
            //        html += "</div>";
            //        $('#formMain').html(html);
            //        $('.container-table .row:last').addClass('row-last');
            //        $('.container-table .row:last .col:last').addClass('col-last');
            //    },
            //    error: function (jqXHR, exception) {
            //        var msg = '';
            //        if (jqXHR.status === 0) {
            //            msg = 'Not connect.\n Verify Network.';
            //        } else if (jqXHR.status == 404) {
            //            msg = 'Requested page not found. [404]';
            //        } else if (jqXHR.status == 500) {
            //            msg = 'Internal Server Error [500].';
            //        } else if (exception === 'parsererror') {
            //            msg = 'Requested JSON parse failed.';
            //        } else if (exception === 'timeout') {
            //            msg = 'Time out error.';
            //        } else if (exception === 'abort') {
            //            msg = 'Ajax request aborted.';
            //        } else {
            //            msg = 'Uncaught Error.\n' + jqXHR.responseText;
            //        }
            //        alert(msg);
            //    }
            //});
        });
    </script>
</body>
</html>
