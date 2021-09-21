// top-level statements

using System;                              

Console.WriteLine($"{Hello.SayHello()} there C# 9 and .NET 5 !");
Console.WriteLine(args.Length);                                         // args still available (conventionally named)

// must be after usings and before any type definitions

static class Hello
{
    public static String SayHello()
    {
        return "hello";
    }
}


// csc helloworld2.cs
// helloworld2
// helloworld1 1 2 3
