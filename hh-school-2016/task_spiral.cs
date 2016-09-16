// Рассмотрим спираль, в которой, начиная с 1 в центре, последовательно расставим числа по часовой стрелке, 
// пока не получится спираль 5 на 5 
//
// 21 22 23 24 25
// 20  7  8  9 10
// 19  6  1  2 11
// 18  5  4  3 12
// 17 16 15 14 13
// Можно проверить, что сумма всех чисел на диагоналях равна 101. 
//
// Чему будет равна сумма чисел на диагоналях, для спирали размером 1039 на 1039?

using System;

namespace task_spiral
{
    public class spiral
    {
        public long get(long number)
        {
            long input_param = (number + 1) / 2;
            long output_param = 0;
            
            if (input_param > 0)
            {
                output_param = 4 * input_param * (4 * input_param * input_param - 1) / 3 - 6 * (input_param - 1) * input_param - 3;
            }
        
            return output_param;
        }
    }
}