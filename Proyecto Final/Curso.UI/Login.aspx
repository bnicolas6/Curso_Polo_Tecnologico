<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Curso.UI.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link rel="icon" href="img/favicon.png" type="image/png" />
    <link rel="shortcut icon" href="img/favicon.ico" type="img/x-icon" />

    <link href="css/bootstrap.css" rel="stylesheet" type="text/css" />
    <link href="css/login.css?V=4" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="js/jquery-3.3.1.min.js"></script>
    <script type="text/javascript" src="js/bootstrap.js"></script>
    <script type="text/javascript" src="js/fontawesome-all.js"></script>
    <script type="text/javascript" src="js/jquery.validate.min.js"></script>
    <script type="text/javascript" src="js/additional-methods.js"></script>
    <script type="text/javascript" src="js/localization/messages_es_AR.min.js"></script>
    <script type="text/javascript" src="js/GyL.Utils.js"></script>

</head>
<body>

    <!-- BEGIN # MODAL LOGIN -->
    <div class="modal fade" id="login-modal" tabindex="-1" role="dialog" aria-labelledby="modalLabel" aria-hidden="true" style="display: none;">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <img class="img-circle" id="img-logo" src="img/logo.png" />
                    <button type="button" class="close" data-dismiss="modal" aria-label="Cerrar">
                        <span class="fas fa-times" aria-hidden="true"></span>
                    </button>
                </div>

                <!-- Begin # DIV Form -->
                <div id="div-forms">

                    <!-- Begin # Login Form -->
                    <form id="form-login">
                        <div class="modal-body">
                            <div id="div-login-msg">
                                <div id="icon-login-msg" class="fas fa-angle-right"></div>
                                <span id="text-login-msg">Ingrese sus credenciales.</span>
                            </div>
                            <input id="input-login-username" class="form-control" name='username' type="text" placeholder="Usuario" required="required" />
                            <input id="input-login-password" class="form-control" name='password' type="password" placeholder="Contraseña" required="required" />
                            <div class="checkbox">
                                <label>
                                    <input type="checkbox" />
                                    Recordarme
                                </label>
                            </div>
                        </div>
                        <div class="modal-footer">
                            <div>
                                <button id="btn-login" type="submit" class="btn btn-primary btn-lg btn-block">Ingresar</button>
                            </div>
                            <div>
                                <button id="btn-link-lost-login" type="button" class="btn btn-link">¿Olvido su contraseña?</button>
                                <button id="btn-link-register-login" type="button" class="btn btn-link">Registrarse</button>
                            </div>
                        </div>
                    </form>
                    <!-- End # Login Form -->

                    <!-- Begin | Lost Password Form -->
                    <form id="form-lost" style="display: none;">
                        <div class="modal-body">
                            <div id="div-lost-msg">
                                <div id="icon-lost-msg" class="fas fa-angle-right"></div>
                                <span id="text-lost-msg">Ingrese su e-mail.</span>
                            </div>
                            <input id="input-lost-email" class="form-control" name='email' type="text" placeholder="E-Mail" required="required" />
                        </div>
                        <div class="modal-footer">
                            <div>
                                <button id="btn-send-lost" type="submit" class="btn btn-primary btn-lg btn-block">Enviar</button>
                            </div>
                            <div>
                                <button id="btn-link-lost-lost" type="button" class="btn btn-link">Ingresar</button>
                                <button id="btn-link-register-lost" type="button" class="btn btn-link">Registrarse</button>
                            </div>
                        </div>
                    </form>
                    <!-- End | Lost Password Form -->

                    <!-- Begin | Register Form -->
                    <form id="form-register" style="display: none;">
                        <div class="modal-body">
                            <div id="div-register-msg">
                                <div id="icon-register-msg" class="fas fa-angle-right"></div>
                                <span id="text-register-msg">Registrese en el sistema.</span>
                            </div>
                            <input id="input-register-username" class="form-control" name='username' type="text" placeholder="Usuario" required="required" />
                            <input id="input-register-email" class="form-control" name='email' type="text" placeholder="E-Mail" required="required" />
                            <input id="input-register-password" class="form-control" name='password' type="password" placeholder="Contraseña" required="required" />
                        </div>
                        <div class="modal-footer">
                            <div>
                                <button id="btn-send-register" type="submit" class="btn btn-primary btn-lg btn-block">Registrarse</button>
                            </div>
                            <div>
                                <button id="btn-link-login-register" type="button" class="btn btn-link">Ingresar</button>
                                <button id="btn-link-lost-register" type="button" class="btn btn-link">¿Olvido su contraseña?</button>
                            </div>
                        </div>
                    </form>
                    <!-- End | Register Form -->

                </div>
                <!-- End # DIV Form -->

            </div>
        </div>
    </div>
    <!-- END # MODAL LOGIN -->


    <script type="text/javascript">

        $.validator.addMethod("usernameValidation", function (value, element) {
            return this.optional(element) || /[a-z]{5,}$/g.test(value);
        }, "Por favor, solo ingrese caracteres en minúsculas.");

        $.validator.addMethod("passwordValidation", function (value, element) {
            return this.optional(element) || /^(?=.*\d)(?=.*[!@#$%^&*])(?=.*[a-z])(?=.*[A-Z]).{8,}$/g.test(value);
        }, "Debes ingresar caracteres en minúscula y mayúscula, números y caracteres especiales...!");

        $.validator.addMethod("emailValidation", function (value, element) {
            return this.optional(element) || /[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?/g.test(value);
        }, "El e-mail ingresado no tiene un formato correcto...!");

        $(document).ready(function (e) {

            var $formLogin = $('#form-login');
            var $formLost = $('#form-lost');
            var $formRegister = $('#form-register');
            var $divForms = $('#div-forms');
            var $modalAnimateTime = 300;
            var $msgAnimateTime = 150;
            var $msgShowTime = 2000;

            var _tools = GyL.Utils.Tools;

            $('#btn-link-lost-login').click(function () {
                modalAnimate($formLogin, $formLost);
            });
            $('#btn-link-register-login').click(function () {
                modalAnimate($formLogin, $formRegister)
            });

            $('#btn-link-login-register').click(function () {
                modalAnimate($formRegister, $formLogin);
            });
            $('#btn-link-lost-register').click(function () {
                modalAnimate($formRegister, $formLost);
            });

            $('#btn-link-lost-lost').click(function () {
                modalAnimate($formLost, $formLogin);
            });
            $('#btn-link-register-lost').click(function () {
                modalAnimate($formLost, $formRegister);
            });

            function modalAnimate($oldForm, $newForm) {
                var $oldH = $oldForm.height();
                var $newH = $newForm.height();
                $divForms.css("height", $oldH);
                $oldForm.fadeToggle($modalAnimateTime, function () {
                    $divForms.animate({ height: $newH }, $modalAnimateTime, function () {
                        $newForm.fadeToggle($modalAnimateTime);
                        $divForms.css("height", "auto");
                    });
                });
            }

            function msgFade($msgId, $msgText) {
                $msgId.fadeOut($msgAnimateTime, function () {
                    $(this).text($msgText).fadeIn($msgAnimateTime);
                });
            }

            function msgChange(divTag, iconTag, textTag, divClass, iconClass, msgText) {
                var msgOld = $(divTag).text();
                msgFade($(textTag), msgText);
                $(divTag).addClass(divClass);
                $(iconTag).removeClass("fa-angle-right").addClass(iconClass + " " + divClass);
                setTimeout(function () {
                    msgFade($(textTag), msgOld);
                    $(divTag).removeClass(divClass);
                    $(iconTag).removeClass(iconClass + " " + divClass).addClass("fa-angle-right");
                }, $msgShowTime);
            }

            $.validator.setDefaults({
                submitHandler: function (form, e) {
                    switch ($(form).attr("id")) {
                        ////////////////////////////////////////////////FORM LOGIN//////////////////////////////////////////////////////////////
                        case "form-login":
                            
                            _tools.ajax('Login.aspx/LoginUser', JSON.stringify({

                                user: $.trim($('#input-login-username').val()),
                                password: $.trim($('#input-login-password').val())

                            }), function (msg) {
                               
                                if (JSON.parse(msg.d).Authentication == 'Ok') {
                                    msgChange('#div-login-msg', '#icon-login-msg', '#text-login-msg', "success", "fa-check", "Login OK...!");
                                    document.location = "Grilla.aspx";
                                }
                                else
                                {
                                    msgChange('#div-login-msg', '#icon-login-msg', '#text-login-msg', "error", "glyphicon-remove", "Login error...!");
                                }
                            });
                            return false;
                            break;
                            //////////////////////////////////////////////FORM LOST//////////////////////////////////////////////////////////////
                        case "form-lost":

                            _tools.ajax('Login.aspx/LostPassword', JSON.stringify({

                                email: $('#input-lost-email').val()

                            }), function (msg) {

                                if (JSON.parse(msg.d).Authentication == 'Error') 
                                    msgChange('#div-lost-msg', '#icon-lost-msg', '#text-lost-msg', "error", "glyphicon-remove", "Se produjo un error al enviar el mail...!");
                                else 
                                    msgChange('#div-lost-msg', '#icon-lost-msg', '#text-lost-msg', "success", "fa-check", "Su e-mail fue enviado...!");
                            });
                            return false;
                            break;
                            ///////////////////////////////////////////FORM REGISTER//////////////////////////////////////////////////////////////
                        case "form-register":

                            _tools.ajax('Login.aspx/RegisterUser', JSON.stringify({

                                user: $('#input-register-username').val(),
                                email: $('#input-register-email').val(),
                                password: $('#input-register-password').val()

                            }), function (msg) {

                                if (JSON.parse(msg.d).Authentication == 'Error')
                                    msgChange('#div-register-msg', '#icon-register-msg', '#text-register-msg', "error", "glyphicon-remove", "Se produjo un error al registrar su usuario...!");
                                else
                                    msgChange('#div-register-msg', '#icon-register-msg', '#text-register-msg', "success", "fa-check", "Registro exitoso...!");
                            });
                            return false;
                            break;
                        default:
                            return false;
                    }
                }
            });

            $('#login-modal').modal('show');
            $('#btn-login').click(function (e) {
                var $formLogin = $('#form-login');
                $formLogin.validate({
                    errorClass: 'errors',
                    rules: {
                        password: {
                            minlength: 8,
                            passwordValidation: true
                        },
                        username: {
                            minlength: 5,
                            usernameValidation: true
                        }
                    }
                });
            });
            $('#btn-send-lost').click(function (e) {
                var $formLogin = $('#form-lost');
                $formLogin.validate({
                    errorClass: 'errors',
                    rules: {
                        email: {
                            emailValidation: true
                        }
                    }
                });
            });
            $('#btn-send-register').click(function (e) {
                var $formLogin = $('#form-register');
                $formLogin.validate({
                    errorClass: 'errors',
                    rules: {
                        email: {
                            emailValidation: true
                        },
                        password: {
                            minlength: 8,
                            passwordValidation: true
                        },
                        username: {
                            minlength: 5,
                            usernameValidation: true
                        }
                    }
                });
            });
            $('#login-modal').on('hidden.bs.modal', function () {
                $(this).modal('show');
            });
        });
    </script>
</body>
</html>
