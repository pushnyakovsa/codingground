using System;
using task_spiral;
using task_das;

class Program
{
    static void Main()
    {
        spiral param_spiral = new spiral();
        das param_das = new das();
        
        Console.WriteLine(param_spiral.get(1039));
        Console.WriteLine(param_das.get());
    }
}
