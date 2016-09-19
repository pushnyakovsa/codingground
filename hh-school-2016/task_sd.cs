// Число 125874 и результат умножения его на 2 — 251748 можно получить друг из друга перестановкой цифр. 
//
// Найдите наименьшее положительное натуральное x такое, что числа 2*x, 5*x можно получить друг из друга перестановкой цифр.

using System;

namespace task_sd
{
    public class sd
    {
        public long factorial(long input_param1, long input_param2)
        {
            int num = 1;
            long output_param = 1;

            do
            {
                output_param = output_param * input_param1;
                num++;
            } while (num <= input_param2);
            
            return output_param;
        }
        
        public static bool same(long input_param)
        {
            int count = 0;
            
            char[] txt_array1 = Convert.ToString(2 * input_param).ToCharArray();
            char[] txt_array2 = Convert.ToString(5 * input_param).ToCharArray();
            
            if (txt_array1.Length == txt_array2.Length)
            {
                int[] int_array1 = new int[txt_array1.Length];
                int[] int_array2 = new int[txt_array1.Length];
                
                Array.Sort(txt_array1);
                Array.Sort(txt_array2);
                
                int_array1 = Array.ConvertAll(txt_array1, c => (int)Char.GetNumericValue(c));
                int_array2 = Array.ConvertAll(txt_array2, c => (int)Char.GetNumericValue(c));
                
                for (int i = 0; i < txt_array1.Length; i++)
                {
                    if (int_array1[i] != int_array2[i])
                    {
                        count = 1;
                    }
                }
                if (count == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        
        public long get()
        {
            int i = 1;
            long output_param = 1;
            
            do
            {
                for (long j = 1; j < factorial(10, i); j++)
                {
                    output_param = factorial(10, i) + j;
                    if (same(output_param) == true)
                    {
                        return output_param;
                    }
                }
                i++;
            } while (i <= 10);
            
            return output_param;
        }
    }
}