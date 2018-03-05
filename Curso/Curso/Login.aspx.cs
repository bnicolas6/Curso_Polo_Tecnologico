using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Curso.Negocio;


namespace Curso
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Boton_Click(object sender, EventArgs e)
        {

            /*    User usuario = new User(TextUser.Text, TextPassword.Text);
                TextUser.Text = "";
                TextPassword.Text = "";

                div1.InnerHtml = usuario.toString();
                if (usuario.verificarLogin() == true)
                    div2.InnerHtml = "Datos ingresados correctamente";
                else
                    div2.InnerHtml = "Datos ingresados incorrectamente";*/

            ////////////////////////////NUEVO/////////////////////////////
            ///
            ///El casteo se hace en tiempo de compilacion, la base del polimorfismo
            ///oPer sigue siendo persona por mas que es un objeto usuario.
            ///para eso agrego el virtual.
            ///Cuando hace la verificacion primer mira el de Persona,
            ///pero como es virtual, se fija que persona es en realidad usuario
            ///entonces pasa a mirar la clase user y encuentra metodo
            ///override, el metodo sobreescribe al metodo de la clase base
            ///Situacion:
            ///Una clase que hereda de otra, si no tiene ningun constructor,
            ///intentara usar el constructor por defecto sin parametros
            ///Cuando usa este, llama al constructor del padre "base()"
            ///pero al constructor por defecto, del padre, si no lo tiene error.


            ///virtual dice que algo puede estar sobreeescrito, si comento
            ///el metodo redefinido en User, 
            /////Si creo una clase que herede de User, el verificar lo va a heredar
            ///como virtual.
            //////Si elimino el verificar de User, y en Persona, le pongo que tire
            ///una excepsion (accede al contenido del verificar de persona), y la tira
            ///
            ///Creo una clase User2, que herede  de User para saber si esta nueva
            ///clase tiene que redefinir el validar, ya estando redefinida en User
            ///(sigue siendo virtual en persona).
            ///Se comprobo que es necesario redefinirlo nuevamente
            ///Es virtual en Persona, se fija directamente en User2, ignorando
            ///User, sin importar que User2 haya heredado de esta ultima.
            ///

            ///overload: sobrecargar

            ////////////////////////////////////////////////////////////////////
            /*User ouser = new User ("123", "455667");
            Persona oPer = null;
            oPer = new User(TextUser.Text, TextPassword.Text);*/
            ///////////////////////////////////////////////////////////////////
            /* if (ouser.verificarLogin()) { //Si no pongo virtual ni nada
             * necesito castear todo.
                 ((User)ouser).verificarLogin();
             }*/

            ///Para no castear:
            ///Creo un metodo "virtual"
            ////////////////////////////////////////////////////////////////////
            /*if (oPer.verificarLogin() == true)
                div2.InnerHtml = "Datos ingresados correctamente";
            else
                div2.InnerHtml = "Datos ingresados incorrectamente";
        }*/
            ////////////////////////////////////////////////////////////////////
            /*   User2 ouser = new User2();
               Persona oPer = null;
               oPer = new User2();

               if (oPer.verificarLogin() == true)
                  div2.InnerHtml = "Datos ingresados correctamente";
              else
                  div2.InnerHtml = "Datos ingresados incorrectamente";
    
           }*/
           /*
            User2 ouser = new User();
            Persona oPer = null;
            oPer = new User();

            if (oPer.verificarLogin2() == true)
                div2.InnerHtml = "Datos ingresados correctamente";
            else
                div2.InnerHtml = "Datos ingresados incorrectamente";*/
        ////////////////////////////////////////////////////////////////////////
           /* User2 ouser = new User2();
            

            if (ouser.verificarLogin4() == true)
                div2.InnerHtml = "Datos ingresados correctamente";
            else
                div2.InnerHtml = "Datos ingresados incorrectamente";*/
        ///////////////////////////////////////////////////////////////////////

            User o = new User2();
        }
    }
}



//Ambito de una variable: scope
//Garbage collector decide cuando eliminar al destructor

    //Removeclass and addClass