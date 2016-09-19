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