using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Camisa
    {
        private double talla;

        public double Talla
        {
            get { return talla; }
            set { talla = value; }
        }

        private string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public Camisa()
        {
            talla = 0;
            color = "";
        }
        public Camisa(double talla, string color)
        {
            this.talla = talla;
            this.color = color;
        }
        public override string ToString()
        {
            return talla + ""+ color;
        }
    }
}
