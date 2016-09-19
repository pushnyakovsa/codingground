// Дано равенство, в котором цифры заменены на буквы:
// rzu + rszx = ruzr 
//
// Найдите сколько у него решений, если различным буквам соответствуют различные цифры (ведущих нулей в числе не бывает).

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
            int z = 0;
            int u = 0;
            int x = 0;
            
            for (r = 1; r <= 9; r++)
            {
                for (s = 0; s <= 9; s++)
                {
                    for (z = 0; z <= 9; z++)
                    {
                        for (u = 0; u <= 9; u++)
                        {
                            for (x = 0; x <= 9; x++)
                            {
                                if ((100 * r + 10 * z + u) + (1000 * r + 100 * s + 10 * z + x) == (1000 * r + 100 * u + 10 * z + r))
                                {
                                    output_param = output_param + 1;
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