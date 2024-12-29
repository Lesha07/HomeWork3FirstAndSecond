using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        //First Program 1
        var name = new List<string>()
        {
            "Adam and Eva",
            "Alex say hello to me",
            "I am Spider-man!",
            "Please say hello to me",
        };

        var filter = name.Where(name => name.StartsWith("a", StringComparison.OrdinalIgnoreCase));

        foreach (var finishFilter in filter)
        {
            Console.WriteLine(finishFilter);
        }
        //Second Program 2
        int[] array = new int[] { 1, 2, 3, 4, 5 };
        int[] secondArray = new int[] { 5, 6, 1, 3, 56, 331, 33};

        array.Select(x =>
        {
            Console.Write(x);
            return x;
        }).ToArray();
        Console.WriteLine();
        secondArray.Select(x =>
        {
            Console.Write(x);
            return x;
        }).ToArray();
        
    }
}

    
        

    


