using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProblem
{

    public class GenericMaximumArray<T> where T : IComparable
    {
        public T[] value;

        public GenericMaximumArray(T[] value)
        {
            this.value = value;
        }
        
        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }

        public T MaxValue(params T[] values)
        {
            var sorted_values = Sort(values);
            return sorted_values[^1];
        }

        public T MaxMethod()
        {
            var Max = MaxValue(value);
            return Max;
        }

    }
}
