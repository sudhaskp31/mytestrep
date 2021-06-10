using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    abstract class MyCalculator<T>
    {
        public abstract T Sum(T value1, T value2);
        public abstract T Product(T value1, T value2);
    }
    class IntCalculator : MyCalculator<int>
    {
       public override int Product(int value1,int value2)
           {
            return value1 * value2;

                    }
        public override int Sum(int value1,int value2)
        {
            return value1 + value2;
        }
       
    }
    class FloatCalculator:MyCalculator<float>
    {
        public override float Product(float value1, float value2)
           {
            return value1 * value2;

        }
        public override float Sum(float value1, float value2)
        {
            return value1 + value2;
        }

    }
}
