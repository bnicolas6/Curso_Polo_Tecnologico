using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public abstract class Figura{ //Agregarle siempre, delante, un public
        protected float _area = 0;
        private string _nombre;

        protected string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public float Area
        {
            get { return _area; }
        }

        public Figura(string name) {
            _nombre = name;
        }

        /*public abstract float calcularArea() { //Evitar usar "_" usar camelCase(estandar)
            //return 0;
            throw new NotImplementedException(); //Lanza error de metodo no implementado
        }*/

        public abstract float calcularArea(); //Si es abstracto no lo tengo que definir aca


    }
}

//calcularArea: metodo, CalcularArea: propiedad.
//Si desde las subclases quiero obtener el area, necesito que Figura tenga un Get.