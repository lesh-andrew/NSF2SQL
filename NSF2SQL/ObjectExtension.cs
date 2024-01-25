using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSF2SQL
{
    public static class ObjectExtension
    {
        public static T[] CastArray<T>(this object obj) where T : class
        {
            // Check if the object is an array
            if (obj is Array array)
            {
                // Create a new array of the same length
                T[] result = new T[array.Length];
                // Loop through the array and cast each element to T
                for (int i = 0; i < array.Length; i++)
                {
                    result[i] = array.GetValue(i) as T;
                }
                // Return the result
                return result;
            }
            // Throw an exception if the object is not an array
            else
            {
                throw new ArgumentException("The object is not an array.");
            }
        }

    }
}
