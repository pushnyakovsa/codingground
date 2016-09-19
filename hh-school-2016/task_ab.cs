// Рассмотрим все возможные числа ab для 1<a<6 и 1<b<6: 
// 22=4, 23=8, 24=16, 25=32 32=9, 33=27, 34=81, 35=243 42=16, 43=64, 44=256, 45=1024, 52=25, 53=125, 54=625, 55=3125 
// Если убрать повторения, то получим 15 различных чисел. 
//
// Сколько различных чисел ab для 2<a<135 и 2<b<136?

using System;
using System.Linq;

namespace task_ab
{
    public class ab
    {
        public long get(int a, int b)
        {
            int len = a * b;
            
            int[] int_array = new int[len];

            for (int i = 3; i < a; i++)
            {
                for (int j = 3; j < b; j++)
                {
                    int_array[len] = (int)Math.Pow(a, b);
                    len = len - 1;
                }
            }
            
            int[] quit_array = int_array.Distinct().ToArray();
            
            return quit_array.Length;
        }
    }
}