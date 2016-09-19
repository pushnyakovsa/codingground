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
        
        public static bool Same(long input_param)
        {
            string a = "";
            string b = "";
            int count = 0;
            
            a = Convert.ToString(2 * input_param)
            b = Convert.ToString(5 * input_param)
            
            var stra = a.ToCharArray();
            var strb = b.ToCharArray();
            
            Array.Sort(stra);
            Array.Sort(strb);
            
            for (int i = 0; i < a.Length; i++)
            {
                if (stra[i] == strb[i])
                {
                    count = count + 1;
                }
            }
            
            if (count == a.Length)
            {
                return true;
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
                    if (2 * output_param == 5 * output_param)
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