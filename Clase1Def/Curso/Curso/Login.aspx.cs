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

        protected void Boton_Click(object sender, EventArgs e){
          
            User usuario = new User(TextUser.Text, TextPassword.Text);
            TextUser.Text = "";
            TextPassword.Text = "";

            div1.InnerHtml = usuario.toString();
            if (usuario.verificarLogin() == true)
                div2.InnerHtml = "Datos ingresados correctamente";
            else
                div2.InnerHtml = "Datos ingresados incorrectamente";
        }

       
    }
}