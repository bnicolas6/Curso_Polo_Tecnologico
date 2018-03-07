using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Triangulo : Figura{
        private float _base,
                      _altura;

        public float Altura
        {
            get { return _altura; }
            set { _altura = value; }
        }

        public float Base
        {
            get { return _base; }
            set { _base = value; }
        }

        public Triangulo(float bas, float altura) :base("Triangulo") {
            _base = bas;
            _altura = altura;
        }

        public override float calcularArea(){
            return (_area = ((Base * Altura) / 2));
        }
    }
}
