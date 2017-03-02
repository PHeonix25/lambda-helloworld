using System;
using System.Linq;
using Amazon.Lambda.Core;

namespace MyFirstLambdaFunction
{
    public class HelloWorld
    {
        public static void SayHi(string name = "World", ILambdaContext context = null)
        {
            context.Logger.LogLine($"Hello {(String.IsNullOrEmpty(name) ? "World" : name)}!");
            context.Logger.LogLine($"The time is {DateTime.UtcNow.ToString("U")}Z.");
            context.Logger.LogLine($"Function name: {context?.FunctionName ?? "Unavailable"}.");
            context.Logger.LogLine($"RemainingTime: {context?.RemainingTime.ToString() ?? "Unavailable"}.");
        }
        public static void Main(string[] args)
        {
            SayHi(args.FirstOrDefault());
        }
    }
}