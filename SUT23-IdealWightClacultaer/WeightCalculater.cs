using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUT23_IdealWightClacultaer
{
    public class WeightCalculater
    {
        public double Height { get; set; }
        public char Gender { get; set; }


        public double GetIdealBodyWeight()
        {
            switch (Gender)
            {
                case 'm':
                    return (Height - 100) - ((Height - 150) / 4);
                case 'w':
                    return (Height - 100) - ((Height - 150) / 2);
                    default:
                    throw new ArgumentException("The Gender is not valid...");
            }
        }

        public int Divide(int numerator, int denominator)
        {
            int result = numerator / denominator;
            return result;
            //PositiveNumbers_ReturnPositive
            //PositiveNumbers_ReturnNegative
        }
    }
}
