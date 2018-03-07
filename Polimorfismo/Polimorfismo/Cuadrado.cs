using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Cuadrado : Figura{
        private float _lado;

        public float Lado
        {
            get { return _lado; }
            set { _lado = value; }
        }

        public Cuadrado(float lado) :base("Cuadrado"){
            _lado = lado;
        }

        public override float calcularArea(){
            return (_area = (float)(Math.Pow(Lado,2)));
        }

    }
}
