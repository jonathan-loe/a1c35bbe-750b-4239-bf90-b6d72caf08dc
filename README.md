# LisGenerator

## What it is

LisGenerator is a Longest Increasing Subsequence (LIS) generator that takes one string input of any number of integers separated by single whitespace. It then outputs the longest increasing subsequence (increased by any number) present in that sequence. If more than 1 sequence exists with the longest length, output the earliest one. See example below.

Input
``` 
6 1 5 9 2
```
Output
```
1 5 9
```

## Current setup

The solution has been setup to run static code analysis during `dotnet build` that checks C# code for conformance to StyleCop's recommended coding styles and design guidelines defined in `.editorconfig`.

## How to verify function correctness

Unit tests constains some test cases provided in the code challenge. To verify the function correctness, please run the following command under the solution root folder to run the unit tests.

```
# dotnet test
```

## How to generate test coverage report 

Run the following command to generate test results.

```
$ dotnet test --collect:"XPlat Code Coverage"
```

Then run the following command to generate the report in HTML.

```
$ reportgenerator
  -reports:"/Path/To/TestProjectFolder/TestResults/{guid}/coverage.cobertura.xml"
  -targetdir:"coveragereport"
  -reporttypes:Html
```

Please refer to Microsoft documentation [here](https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-code-coverage?tabs=linux#integrate-with-net-test).
