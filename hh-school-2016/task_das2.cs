// 

using System;

namespace task_das2
{
    public class das2
    {
        public long get()
        {
            long output_param = 0;
            
            int r = 0;
            int s = 0;
            int t = 0;
            int u = 0;
            int q = 0;
            
            for (r = 1; r <= 4; r++)
            {
                for (s = 2; s <= 9; s++)
                {
                    for (t = 0; t <= 9; t++)
                    {
                        if (t != 1 || t != 2)
                        {
                            for (u = 1; u <= 9; u++)
                            {
                                for (q = 0; q <= 9; q++)
                                {
                                    if ((1000 * r + 100 * q + 10 * t + r) + (1000 * r + 100 * q + 10 * r + s) == (1000 * s + 100 * q + 10 * u + t))
                                    {
                                        output_param = output_param + 1;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        
            return output_param;
        }
    }
}