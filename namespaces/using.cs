/*

    The ‘using’ block is used to obtain a resource and process it and then automatically dispose of when the execution of the block completed.

*/
using System;
using System.IO;

class namespace_using
{
    void Test() {
        string manyLines = @"This is line one
        This is line two
        Here is line three
        The penultimate line is line four
        This is the final, fifth line.";

        using (var reader = new StringReader(manyLines))
        {
            string? item;
            do
            {
                item = reader.ReadLine();
                Console.WriteLine(item);
            } while (item != null);
        }

        // reader it's not acessible after using block 

        // Beginning with C# 8.0, you can use the following alternative syntax for the using statement that doesn't require braces:
        using var reader02 = new StringReader(manyLines);
    }
}