using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jenkins_Calc_sample
{
    public class CalcOperations
    {
        public int Firstnumber { get; set; }
        public int Secondnumber { get; set; }

        public int Add()
        {
            return Firstnumber+Secondnumber;
        }

        public int Sub()
        {
            return Firstnumber - Secondnumber;
        }

        public int Multiply()
        {
            return Firstnumber * Secondnumber;
        }
    }
}
