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

        Console.WriteLine("Task 1 result: {0}", param_sd.get());
        Console.WriteLine("Task 2 result: {0}", param_spiral.get(1117));
        Console.WriteLine("Task 3 result: {0}", param_das2.get());
        Console.WriteLine("Task 4 result: {0}", param_ab.get(135, 136));
        Console.WriteLine("Task 5 result: {0}", param_fact.get(670000000, 680000000, 479001600, 12));
    }
}