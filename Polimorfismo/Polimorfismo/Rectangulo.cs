using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Rectangulo : Figura{
        private float _ladoA,
                      _ladoB;

        public float LadoB
        {
            get { return _ladoB; }
            set { _ladoB = value; }
        }

        public float LadoA
        {
            get { return _ladoA; }
            set { _ladoA = value; }
        }

        public Rectangulo (float ladoA, float ladoB) :base("Rectangulo"){
            _ladoA = ladoA;
            _ladoB = ladoB;
        }

        public override float calcularArea(){
            return (_area = (LadoA * LadoB));
        }
    }
}
