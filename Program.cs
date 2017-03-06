using System;
using System.Linq;
using Amazon.Lambda.Core;

namespace MyFirstLambdaFunction
{
    public class HelloWorld
    {
        public static string SayHi(ILambdaContext context, string name = "World")
        {
            var output = $"Hello {(String.IsNullOrEmpty(name) ? "World" : name)} " +
                         $"from {context?.FunctionName ?? "someone unknown"}.";
            context?.Logger.LogLine(output);
            context?.Logger.LogLine($"The time is {DateTime.UtcNow.ToString("U")} UTC.");
            return output;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(SayHi(null, args.FirstOrDefault()));
        }
    }
}