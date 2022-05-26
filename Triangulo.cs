using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Triangulo
    {
        private int angulo;
        private int ladoA;
        private int ladoB;

        public int LadoA
        {
            get { return ladoA; }
            set { ladoA = value; }
        }

        public int LadoB
        {
            get { return ladoB; }
            set { ladoB = value; }
        }

        public int Angulo
        {
            get { return angulo; }
            set { angulo = value; }
        }

        public void CalcularPerimetro()
        {
            throw new System.NotImplementedException();
        }

        public void CalcularSuperficie()
        {
            throw new System.NotImplementedException();
        }
    }
}
