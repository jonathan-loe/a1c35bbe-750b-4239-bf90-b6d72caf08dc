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

# How to verify

Unit tests constains some test cases provided in the code challenge. To verify the function correctness, please run the following command under the root folder to run the unit tests.

```
# dotnet test
```
