using System;

namespace OperatorsAndOperands
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We're talking about Operators and Operands here.");
            int firstValue = 7, secondValue = 2;
            //Arithmetic
            Console.WriteLine($"Addition: {firstValue} + {secondValue} = {firstValue + secondValue}");
            Console.WriteLine($"Subtraction: {firstValue} - {secondValue} = {firstValue - secondValue}");
            Console.WriteLine($"Multiplication: {firstValue} * {secondValue} = {firstValue * secondValue}");
            //ignore the bug
            Console.WriteLine($"Division: {firstValue} / {secondValue} = {firstValue / secondValue}");
            Console.WriteLine($"Modulus: {firstValue} % {secondValue} = {firstValue % secondValue}");
           
            Console.WriteLine($"Pre-decrement: ++{firstValue} = {++firstValue}");
            Console.WriteLine($"Pre-decrement: --{firstValue} = {--firstValue}");


            //Logical
            bool trueVal = true, falseVal = false, matchingTrueVal=true, matchingFalseVal=false;
            //AND-&
            Console.WriteLine($"{trueVal} & {matchingTrueVal} = {trueVal & matchingTrueVal}");
            Console.WriteLine($"{trueVal} & {falseVal} = {trueVal & falseVal}");
            Console.WriteLine($"{falseVal} & {matchingFalseVal} = {falseVal & matchingFalseVal}");
            Console.WriteLine($"{falseVal} & {trueVal} = {falseVal & trueVal}");
            //OR-|
            Console.WriteLine($"{trueVal} | {matchingTrueVal} = {trueVal | matchingTrueVal}");
            Console.WriteLine($"{trueVal} | {falseVal} = {trueVal | falseVal}");
            Console.WriteLine($"{falseVal} | {matchingFalseVal} = {falseVal | matchingFalseVal}");
            Console.WriteLine($"{falseVal} | {trueVal} = {falseVal | trueVal}");
            //XOR-^
            Console.WriteLine($"{trueVal} ^ {matchingTrueVal} = {trueVal ^ matchingTrueVal}");
            Console.WriteLine($"{trueVal} ^ {falseVal} = {trueVal ^ falseVal}");
            Console.WriteLine($"{falseVal} ^ {matchingFalseVal} = {falseVal ^ matchingFalseVal}");
            Console.WriteLine($"{falseVal} ^ {trueVal} = {falseVal ^ trueVal}");
            //CONDITIONAL AND-&&
            Console.WriteLine($"{trueVal} && {matchingTrueVal} = {trueVal && matchingTrueVal}");
            Console.WriteLine($"{trueVal} && {falseVal} = {trueVal && falseVal}");
            Console.WriteLine($"{falseVal} && {matchingFalseVal} = {falseVal && matchingFalseVal}");
            Console.WriteLine($"{falseVal} && {trueVal} = {falseVal && trueVal}");
            //CONDITIONAL OR-||
            Console.WriteLine($"{trueVal} || {matchingTrueVal} = {trueVal || matchingTrueVal}");
            Console.WriteLine($"{trueVal} || {falseVal} = {trueVal || falseVal}");
            Console.WriteLine($"{falseVal} || {matchingFalseVal} = {falseVal || matchingFalseVal}");
            Console.WriteLine($"{falseVal} || {trueVal} = {falseVal || trueVal}");
        }
    }
}
