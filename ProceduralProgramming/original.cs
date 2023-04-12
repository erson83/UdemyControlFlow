
using System;

private class original
{

    Console.WriteLine("What is you name?");
        var name = Console.ReadLine();

    var array = new char[name.Length];
        for (var i = name.Length; i > 0; i--)

        array[name.Length - i] = name[i - 1];
        var reversed = new string(array);
    Console.WriteLine("Reversed name: " + reversed);
 }