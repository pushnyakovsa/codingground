// Наименьшее число m, такое, что m! делится без остатка на 10 — это m=5 (5! = 120).
// Аналогично, наименьшее число m, такое, что m! делится без остатка на 25 — это m=10.
// В общем случае, значение функции s(n) равно наименьшему числу m, такому что m! без остатка делится на n.
// Определим функцию S(M, N) = ∑s(n) для всех n ∈ [M, N]. К примеру, S(6, 10) = 3 + 7 + 4 + 6 + 5 = 25.
// Найдите S(670000000, 680000000).

using System;

namespace task_factorial
{
    public class factorial
    {
        public static long fact(long a, long b)
        {
            long output_param = 1;
            
            if (b != 0)
            {
                output_param = b * a;
            }
            else if (b == 0)
            {
                if (a == 1)
                {
                    return output_param;
                }
                else if (a > 1)
                {
                    for (int i = 2; i <= a; i++)
                    {
                        output_param = output_param * i;
                    }
                }
            }
            
            return output_param;
        }
        
        public long get(long m, long n, long x, long y)
        {
            long output_param = 0;
            
            for (long i = m; i <= n; i++)
            {
                if ((fact(y + 1, x) % i) == 0)
                {
                    output_param = output_param + y + 1;
                }
                else
                {
                    x = fact(y + 1, x);
                    y++;
                }
            }
            
            return output_param;
        }
    }
}