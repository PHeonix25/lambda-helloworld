# HelloWorld Caller

This is the companion app to the [Hello World Caller](https://github.com/PHeonix25/lambda-helloworldcaller) that I wrote to accompany my presentation on AWS Lambda basics at the Amsterdam .Net user-group.

## Disclaimers!

This repo is really nothing special! It's a simple `dotnet core` application that reads some input into some conditional output, logs some messages to the `ILambdaContext` and then returns a `Hello World` string.

Strings and output are pretty hard-coded, there are no tests, and everything fits on a single screen at 200% zoom (so: PRESENTATION code, not PRODUCTION code) - use at your own peril.

This might come in handy if someone is looking for the absolute simplest example of how to write their first Lambda (and practice deploying/calling it)

## How does it work

- `dotnet restore` will pull down the AWS Tooling for Lambda: `Amazon.Lambda.Tools` and the required `Core` namespaces for the `ILambdaContext`
- `dotnet run` will execute the Main function in Program.cs - TA DAAA!

I hope the code is pretty self-explanatory, but at a pseudo-code level, it does the following:

- The Lambda entry point is defined in the `aws-lambda-tools-defaults.json`
- The Lambda (when invoked) will populate the paramters based off the inputs and the AWS defaults
- We will build up a string to reply with, including the use of any payload input
- We log both the output that we will send, and the time, as separate statements to the `context`
- We return the string that we built up; our `Hello World` statement

If you'd like to see how you can invoke this, check out the matching repo [over here](https://github.com/PHeonix25/lambda-helloworldcaller)