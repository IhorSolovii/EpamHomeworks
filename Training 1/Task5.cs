using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_1
{
    public class ComplexNumber
    {
        #region Fields
        private double real;
        private double imaginary;
        #endregion

        #region Constructors
        public ComplexNumber(double real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }
        #endregion

        #region Methods
        public string GetComplexNumber()
        {
            return $"z = {real} + {imaginary}i";
        }
        #endregion

        #region Operators overloading
        public static ComplexNumber operator *(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber((c1.real * c2.real) - (c1.imaginary * c2.imaginary), (c1.real * c2.imaginary) + (c1.imaginary * c2.real));
        }
        public static ComplexNumber operator /(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(((c1.real * c2.real) + (c1.imaginary * c2.imaginary)) / (c2.real * c2.real + c2.imaginary * c2.imaginary), ((c1.imaginary * c2.real) - (c1.real * c2.imaginary)) / (c2.real * c2.real + c2.imaginary * c2.imaginary));
        }
        #endregion
    }
}
