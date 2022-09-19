﻿using System;
using System.Threading.Tasks;

namespace keywords
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("=================    Generic Where Constraints Examples ======================");
            GenericWhereConstraints.Examples();
            Console.WriteLine("=================    readonly Keyword Examples ======================");
            ReadonlyKeywordExamples.Examples();
            Console.WriteLine("=================    using Keyword Examples ======================");
            UsingStatements.Examples();
            Console.WriteLine("=================    try-catch Keyword Examples ======================");
            await AsyncExceptionExamples.Examples();
        }
    }

    // <ShadowsFileScopedType>
    // In File2.cs:
    // Doesn't conflict with HiddenWidget 
    // declared in File1.cs
    public class HiddenWidget
    {
        public void RunTask()
        {
            // omitted
        }
    }
    // </ShadowsFileScopedType>
}
