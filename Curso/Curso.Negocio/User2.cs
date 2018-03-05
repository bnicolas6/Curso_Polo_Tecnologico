using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Negocio
{
    public class User2:User{

        public override bool verificarLogin(){
            //return base.verificarLogin();
            return true;
        }

        /*public bool verificarLogin4() {
            return verificarLogin3();
        }
        */

        public new bool verificarLogin3() {
            return true;
        }
        //////login4, sigue heredando como protected
        //ahora tengo en padre e hijo el mismo metodo, hay overload
        /// con new sobrecarga y pisa el metodo, lo redefino y mato al anterior
        ///Otro modificador:
        ///internal (metodo o clase, no es recomendable en atributos). 
        ///Solo es visible dentro del namespace, en este caso Curso.Negocio podria acceder,
        ///pero no Curso.
        //DOM Modela items a traves de javascript 
    }
}
