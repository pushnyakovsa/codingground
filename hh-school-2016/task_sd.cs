// 

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
        
        public static void Sort(int[] a)
        {
            qSort(a, 0, a.Length - 1);
        }
        
        private static void qSort(int[] a, int low, int high)
        {
            int i = low;
            int j = high;
            int x = a[(low + high) / 2];
            do
            {
                while (a[i] < x) ++i;
                while (a[j] > x) --j;
                if (i <= j)
                {
                    int temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                    i++; j--;
                }
            } while (i < j);
            if (low < j) qSort(a, low, j);
            if (i < high) qSort(a, i, high);
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