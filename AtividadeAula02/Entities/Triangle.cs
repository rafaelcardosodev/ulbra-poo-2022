using System;
using System.Transactions;

namespace AtividadeAula02.Entities
{
    public class Triangle
    {
        private double width;
        private double height;
        
        public Triangle(){}

        public Triangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        
        public double Width
        {
            get => width;
            set => width = value;
        }

        public double Height
        {
            get => height;
        }

        public double GetTotalArea(String triangleType)
        {
            if (triangleType.ToLower() == "escaleno" || triangleType.ToLower() == "retangulo" || triangleType.ToLower() == "retângulo")
            {
                return this.width * this.height / 2;
            }
            else if (triangleType.ToLower() == "equilatero" || triangleType.ToLower() == "equilátero")
            {
                return Math.Sqrt(3) / 4 * Math.Pow(this.width, 2);
            }
            else
            {
                Console.Write("Digite um valor válido");
                return -1;
            }
        }

        public override string ToString()
        {
            return $"{nameof(width)}: {width}, {nameof(height)}: {height}";
        }
        
        
    }
}