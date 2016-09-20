using System;
using task_spiral;
using task_das1;
using task_das2;
using task_sd;
using task_ab;
using task_factorial;


class Program
{
    static void Main()
    {
        spiral param_spiral = new spiral();
        das1 param_das1 = new das1();
        das2 param_das2 = new das2();
        sd param_sd = new sd();
        ab param_ab = new ab();
        factorial param_fact = new factorial();
        
        Console.WriteLine(param_spiral.get(1039));
        Console.WriteLine(param_das1.get());
        Console.WriteLine(param_das2.get());
        Console.WriteLine(param_sd.get());
        Console.WriteLine(param_ab.get(135, 136));
        Console.WriteLine(param_fact.get(670000000, 680000000, 479001600, 12));
    }
}