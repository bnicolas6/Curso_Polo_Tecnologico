using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Circulo : Figura{
        private float _radio;

        public float Radio
        {
            get { return _radio; }
            set { _radio = value; }
        }

        public Circulo(float radio) :base("Circulo"){
            _radio = radio;
        }

        public override float calcularArea(){ //Uso la clase Math
            return _area = (float)(Math.PI * Math.Pow(Radio, 2));  //Devuelve double si no casteo.
        }

    }
}
